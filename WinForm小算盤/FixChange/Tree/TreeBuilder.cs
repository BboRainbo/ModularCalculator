using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForm小算盤.FixChange.Tree
{
    internal class TreeBuilder
    {
        public static Node Build(List<string> postfix)
        {
            HashSet<string> Operators = new HashSet<string>()
            {"+","-","X","/"};
            Stack<Node> stack = new Stack<Node>();
            //從頭到尾掃描 List<string>
            //每一個 token都 new 節點
            //遇到運算元就把前兩個節點 left = 數字1，right = 數字2
            //所以建樹過程也需要 stack
            //掃描完畢後，stack 中會剩下唯一一個 root 節點(?
            for (int i = 0; i < postfix.Count; i++)
            {
                string cur = postfix[i];
                Node node = new Node(cur);

                if (Operators.Contains(cur))
                {
                    node.Right = stack.Pop();
                    node.Left = stack.Pop();
                    stack.Push(node);
                }
                else
                {
                    stack.Push(node);
                }
            }       
            return stack.Pop();
        }
        //所有new 出來的 node 都互相參考，所以整棵樹都不會消失
        //所以我想要棄用這棵樹的時候，只要 root =null，記憶體就會全部釋放
    }
}
