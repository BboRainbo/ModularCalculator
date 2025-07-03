namespace WinForm小算盤.FixChange
{
    internal class Tokenizer
    {
        public static List<string> StringToToken(string input)
        {
            HashSet<string> OP = new HashSet<string> { "+", "-", "X", "/" };
            List<string> result = new List<string>();
            List<char> current = new List<char>();

            for (int i = 0; i < input.Length; i++)
            {
                char ch = input[i];
                //處理如何區別"減"與"負"
                if (ch.ToString() == "-")
                {
                    //"負"的條件是出現在開頭或是"("之後以及運算元之後
                    bool isNegToken = 
                        (
                        i == 0 ||    //開頭
                        (result.Count != 0 && result.Last() == "(") ||  //"("之後(且確保前面已經有東西)
                        (result.Count != 0 && OP.Contains(result.Last()))//運算符之後(且確保前面已經有東西)
                        ); 
                    if (isNegToken)
                    {
                        current.Add(ch);
                        continue;
                    }
                }
                //如果是數字，繼續累加
                if (char.IsDigit(ch) || (ch.ToString() == "."))
                    current.Add(ch);

                //如果不是數字，輸出 current 與result[i]成為 token，並且清除 current
                else
                {
                    if (current.Count != 0)
                    {
                        result.Add(new string(current.ToArray()));  // 加入完整數字 token
                        current.Clear();
                    }
                    result.Add(ch.ToString());
                }
            }

            // 字串掃描結束後加入剩餘數字 token
            if (current.Count != 0)
            {
                result.Add(new string(current.ToArray()));
                current.Clear();
            }
            Console.WriteLine(result.ToArray());
            return result;
        }
    }
}

        
