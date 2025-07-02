using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForm小算盤.History
{
    internal class History
    {

        private static List<string[]> history = new List<string[]>();


        /// <summary>
        /// 添加歷史紀錄並回傳完整運算字串
        /// </summary>
        /// <param name="left"></param>
        /// <param name="OP"></param>
        /// <param name="right"></param>
        /// <param name="result"></param>
        /// <returns></returns>
        public static string Add(string left, string OP, string right, string result)
        { 
            if (history.Count > 4) {history.RemoveAt(4);}
            history.Insert(0,new string[] { left, OP, right, result });
            return ($"{left} {OP} {right} = {result}");
        }
        /// <summary>
        /// 回傳完整歷史算式
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public static string Show(int index)
        {
            if (history.Count >= index+1)
                return ($"{history[index][0]}{history[index][1]}{history[index][2]}={history[index][3]}");
            else return ("");
        }
        /// <summary>
        /// 將num1、運算子、num2、結果打包回傳
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public static string[] Read(int index)
        {
            if (history.Count >= index + 1)
                return history[index];
            else return new string[] { "0", "0", "0", "0" };
        }
        //public void remove(int index)
        //{
        //    history.RemoveAt(index); 
        //}

    }
}
