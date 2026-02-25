using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LeetCode2025
{
    internal class LargestAndSmallestNumberInArray
    {

        /*
         1. Find the min and max in a array
         2. Find Second largest from Array
         
         */

        // 1. Find the min and max in a array
        public static void LargestNumberInArrayM(int[] array)
        {
           int max = array[0];
            int min = array[0];

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
                else if (array[i] < min)
                {
                    min = array[i];
                }
            }
            Console.WriteLine("Max Number Is:" + max);
            Console.WriteLine("Min Number is:"+ min);
        }

     //   2. Find Second largest from Array
        public static void SecondlargestNumber(int[] array)
        {
            int FirstLarget = array[0]; // 1,4,2,5,8
            int SecondLargest = 0;
            for(int i = 1;i < array.Length; i++)
            {
                if (array[i] > FirstLarget)
                {
                    FirstLarget = array[i];
                    SecondLargest = FirstLarget;
                }

                else if (array[i] > SecondLargest)
                {
                    SecondLargest = array[i];
                }
            }
            Console.WriteLine("Max Number Is:" + FirstLarget);
            Console.WriteLine("2nd Min Number is:" + SecondLargest);
        }

    }

   
}
