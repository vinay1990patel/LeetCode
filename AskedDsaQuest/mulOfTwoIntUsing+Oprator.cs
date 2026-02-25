using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AskedDsaQuest
{
    internal class SumOfTwoIntUsing_Oprator
    {
        public static void SumOfTwoIntUsing_OpratorMethod(int a , int b)
        {
            int min = Math.Min(a, b);
            int max = Math.Max(a, b);
            int result = 0;
            for(int i =0; i < min; i++)
            {
                result += max; 
            }

            Console.WriteLine("Multipifcation of a and b:" + result);
        }
    }
}
