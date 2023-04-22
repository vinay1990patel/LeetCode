using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LeetCode
{
    internal class FindPivotIndex
    {
        public static int Pivot(int[] nums)
        {
            // 1,7,3,6,5,6

            int total = nums.Sum();
            int pivot = 0;
            int leftSum = 0;
            for(int i =0; i< nums.Length; i++)
            {
                leftSum = leftSum + nums[i];
                pivot = i;
                if (leftSum == total)
                {
                   
                   return pivot = i;
                }
                else
                {
                    total = total - nums[i];
                   
                }
            }

            return -1;

        }
    }
}
