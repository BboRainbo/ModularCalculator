using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForm小算盤.FixChange
{
    internal class ChangeFix
    {

        //public static string Run(List<string>, string Mode)
        public static string[] InfixToPrefix(string num1, string OP, string num2)
        {
            string[] result = new string[] { OP, num1, num2 };
            return result;
        }
        public static string[] InfixToPostfix(string num1, string OP, string num2)
        {
            string[] result = new string[] { num1, num2, OP };
            return result;
        }
        public static string Print(string[] input)
        {
            return string.Join(", ", input); ;
        }

    }

}
