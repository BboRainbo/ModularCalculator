using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Winform小算盤;
using WinForm小算盤.Operator;

namespace WinForm小算盤
{
    internal class Calculator
    {
        public static double Calculate(string num1, string OP, string num2)
        {
            double Num1 = double.Parse(num1);
            double Num2 = double.Parse(num2);
            AOperator op = OperatorFactory.CreateOperator(OP);
            double result = op.Calculate(Num1, Num2);
            return result;             
        }
    }
}
