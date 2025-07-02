using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForm小算盤.FixChange.Tree
{
    internal class Node
    {
        public string value = "";
        public Node? left;
        public Node? right; // nullable的寫法
        public Node(string VAL)
        {
            value = VAL;
            left = null;
            right = null;
        }
    }
}
