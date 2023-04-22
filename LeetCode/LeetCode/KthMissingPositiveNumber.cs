using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LeetCode
{
    internal class KthMissingPositiveNumber
    {

        public static int  kthMissing(int[] nums, int k)
        {

            int[] result = new int [2000];
            int n = 0;
            int count = 0;
            int m = 0;
            for(int i =1; i <= 2000; i++)
            {

                if (n == nums.Length)
                {
                    n = 0;
                }
                if (nums[n] == i && count < nums.Length)
                {
                   // continue;
                    n = count +1;
                    count = count+1;
                    continue;

                }

             

                result[m] = i;
                m++;
               

               
            }



            return result[k-1] ; 
        }
    }
}
