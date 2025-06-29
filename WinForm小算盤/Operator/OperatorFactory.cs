using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Winform小算盤;

namespace WinForm小算盤.Operator
{
    internal class OperatorFactory
    {

        public static AOperator CreateOperator(string op)
        {
            var map = new Dictionary<string, OperatorType>
            {
                { "+", OperatorType.加 },
                { "加", OperatorType.加 },
                { "-", OperatorType.減 },
                { "減", OperatorType.減 },
                { "X", OperatorType.乘 },
                { "乘", OperatorType.乘 },
                { "/", OperatorType.除 },
                { "除", OperatorType.除 }
            };
            OperatorType type  = map[op];
            AOperator result = new None();
            switch (type)
            {
                case OperatorType.加:
                    result = new Plus();
                    break;
                case OperatorType.減:
                    result = new Minus();
                    break;
                case OperatorType.乘:
                    result = new Multiple();
                    break;
                case OperatorType.除:
                    result = new Divide();
                    break;
            }
            return result;
        }
    }
}
