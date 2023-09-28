using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LeetCode
{
    internal class DecialToBinary
    {
        public static void DecimalToBinaries()
        {
            int number = 4;
            string result = string.Empty;
            for (int i = 0; number > 0; i++)
            {
                result = number % 2 + result;
                number = number / 2;
            }

            Console.WriteLine(result);
        }
    }
}
