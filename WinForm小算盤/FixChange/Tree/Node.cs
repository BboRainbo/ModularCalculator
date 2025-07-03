using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForm小算盤.FixChange.Tree
{
    internal class Node
    {
        public string Value = "";
        public Node? Left;
        public Node? Right; // nullable的寫法
        public Node(string VAL)
        {
            Value = VAL;
            Left = null;
            Right = null;
        }
    }
}
