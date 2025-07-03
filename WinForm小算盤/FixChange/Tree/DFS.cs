using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForm小算盤.FixChange.Tree
{
    internal class DFS
    {
        private Node node;
        private string mode;
        private string output="";
        HashSet<string> Operators = new HashSet<string>() { "+", "-", "X", "/" };
        public DFS(Node ROOT,string mode)
            { 
            this.node = ROOT; 
            this.mode = mode;
            }

        //掃描根結點
        //掃描左節點
        //掃描右節點
        public string TreeTravel(Node? node)
        {
            if (node == null) return "";

            if (mode == "前序")
            {
                Console.WriteLine(node.Value);
                output += node.Value;
            }
            TreeTravel(node.Left);
            if (mode == "中序")
            {
                Console.WriteLine(node.Value);
                output += node.Value;
            }
            TreeTravel(node.Right);
            if (mode == "後序")
            {
                Console.WriteLine(node.Value);
                output += node.Value;
            }

            return output;
        }
    }
}
