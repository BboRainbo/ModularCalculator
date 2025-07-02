using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace WinForm小算盤.FixChange
{
    internal class TokenToPostFix
    {
        public static List<string> Run(List<string> input)
        {
            var result = new List<string>();
            Stack<string> stack = new Stack<string>();
            HashSet<string> OP = new HashSet<string>() { "+", "-", "X", "/" };
            Dictionary<string, int> Pri = new Dictionary<string, int>()
            {
                { "+", 1 },
                { "-", 1 },
                { "X", 2 },
                { "/", 2 }
            };
            //如果遇到非運算元 =>放入result
            //遇到運算元，先存起來
            //遇到下一個運算元，檢查stack pop的優先及是否比cur高，是的話就pop，並且把cur push
            //不是的話就單純繼續 push cur
            //=>這邊可以多一個 list 紀錄 push 進入的運算子優先級，就不用一直操作 stack
            //到字串結尾 把所有運算子都pop乾淨
            //括號的處理 : 
            //進入(後，正常運行，遇到低優先順序的仍然會 pop stack，但如果遇到(就強制停止
            //另一個條件是遇到)就連續pop直到(出現
            //其實是在規範兩種邊界，當前stack pop 不可以管超過左括號，看到右括號運算必須在此結算
            //如果我把普通運算的行為(無括號)變成一個函數，遇到括號就像是呼叫一個遞迴，
            //裡面一樣在進行這個普通且無括號的算數，也可能繼續遞迴下去 例如多層括號

            for (int i = 0; i < input.Count; i++)
            {
                string cur = input[i];
                if (!OP.Contains(cur))
                    result.Add(cur);
                //遇到非數字時
                else
                {
                    //把優先順序高於cur 的全部倒出來
                    while (true)
                    {
                        if (stack.Count > 0 && (Pri[stack.Peek()] >= Pri[cur]))
                        {
                            result.Add(stack.Pop());
                            continue;
                        }
                        break;
                    }
                    //把當前符號推入 stack
                    stack.Push(cur);

                }
            }
            while (stack.Count > 0)
            {                    
                result.Add(stack.Pop());
            }
            return result;
        }
    }
}
