using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Winform小算盤;

namespace WinForm小算盤.Operator
{
    internal class Plus : AOperator
    {


        public override double Calculate(double leftOP, double rightOP)//參數放在建構元會更好
        {
            return leftOP + rightOP;
        }
    }
}
