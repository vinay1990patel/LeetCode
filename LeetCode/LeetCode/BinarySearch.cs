using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LeetCode
{
    internal class BinarySearch
    {

        public static int BinarySearch1(int[] nums, int target)
        {
            int start = 0;
            int end = nums.Length;
            int l = nums.Length-1;
          //  int mid = (end + start) / 2;
            while (start <= end)
            {
              int  mid = (start + end) / 2;

                if(target > nums[l])
                {
                    return -1;
                }

                if (target > nums[mid])
                {
                    start = mid + 1;
                }
                else
                {
                    end = mid - 1;
                }

                if (nums[mid] == target)
                {
                    Console.WriteLine(mid);

                    return mid;

                   
                }

               
               

            }
            return -1;
        }
    }
}
