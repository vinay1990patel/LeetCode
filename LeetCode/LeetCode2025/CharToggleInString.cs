using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LeetCode2025
{
    internal class CharToggleInString
    {

        public static void CharToggleInStringMethod(string chars)
        {
            for (int i = 0; i < chars.Length; i++) {
                if (chars[i] >= 65 && chars[i] <= 90)
                {
                    Console.WriteLine((char) (chars[i] + 32));
                }
                else {
                    Console.WriteLine((char)(chars[i] - 32));
                }
              }
        }
    }
}
