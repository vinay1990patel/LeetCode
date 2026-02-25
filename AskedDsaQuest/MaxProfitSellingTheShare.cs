using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AskedDsaQuest
{
    internal class MaxProfitSellingTheShare
    {

        public static void MaxProfitSellingTheShareBruteForce(int [] array) // 7 1 5 3 6 4   -6 
        {
            int maxP = int.MinValue;
            int result = 0;
            for (int i = 0; i < array.Length; i++) {

                for (int j = i+1; j < array.Length; j++)
                {
                    result =  array[j] - array[i];
                    maxP = Math.Max(maxP, result);
                }
            }
            Console.WriteLine("Max profit :"+ maxP);
        }
    }
}
