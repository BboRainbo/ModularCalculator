using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Winform小算盤;

namespace WinForm小算盤.Operator
{
    internal class None : AOperator
    {


        public override double Calculate(double leftOP, double rightOP)
        {
            return double.MaxValue;
        }

    }
}
