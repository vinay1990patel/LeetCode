using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LeetCode
{
    internal class LargestNumber
    {
        public static void LargestNumbers(int[] input)
        {
            int temp = 0;
            for(int i =0; i< input.Length; i++)
            {
                for(int j =i; j< input.Length; j++)
                {
                    if (input[i] < input[j])
                    {
                        temp = input[i];
                        input[i] = input[j];
                        input[j] = temp;


                    }
                }
            }

            for(int i =0;i < input.Length; i++)
            {
                Console.WriteLine(input[i]);
            }
        }


    }
}
