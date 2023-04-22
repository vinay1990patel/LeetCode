using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LeetCode
{
    internal class PeakIndexinaMountainArray
    {

        public static int peakIndex(int[] nums)   // O(logn)
        {

            int start = 0;
            int end = nums.Length - 1;
            int mid = 0;
            while(start < end)
            {
                mid = (start + end) / 2;
                if (nums[mid] < nums[mid + 1])
                {
                    start = mid+1;
                }

                else
                {
                    end = mid; 
                }

            }

            return start;
        }


        public static int PeakMountainByLiner(int[] arr)
        {


            int temp = 0;

            for(int i=0; i < arr.Length; i++)
            {
                if (arr[temp] < arr[i])
                {
                    temp = i;
                }
                //else
                //{
                //    temp++;
                //}
            }
            return temp;
        }

    }
}
