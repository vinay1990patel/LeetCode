using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LeetCode
{
    internal class ThirdHighestNumber
    {
        public static void NthHighestSalary(int[] input)
        {
            int first = 0, second = 0,third = 0;

            for(int i =0; i <input.Length; i++)
            {
                if (input[0] > first)
                {
                    third = second;
                    second = first;
                    first = input[i];
                }

                else if (input[i] > second)
                {
                    third = second;
                    second = input[i];
                }
                else if (input[i] > third)
                {
                    third = input[i];
                }
            }

            Console.WriteLine(third);
        }
    }
}
