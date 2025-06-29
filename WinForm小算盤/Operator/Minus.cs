using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Winform小算盤;

namespace WinForm小算盤.Operator
{
    internal class Minus : AOperator
    {


        public override double Calculate(double leftOP, double rightOP)
        {
            return leftOP - rightOP;
        }

    }
}
