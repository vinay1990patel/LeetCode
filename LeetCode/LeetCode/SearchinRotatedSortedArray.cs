using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LeetCode
{
    internal class SearchinRotatedSortedArray
    {
       public static int RotedArraySearch(int[] nums, int target)
        {

            int start = 0;
            int end = nums.Length - 1;

            int mid = 0;

            if(nums.Length == 1)
            {
                if(target == nums[0])
                {
                    return 0;
                }
                else
                {
                    return -1;
                }
            }

            while(start < end)
            {
                mid = (start + end) / 2;
                if (nums[mid] >= nums[0])
                {
                    start = mid+1;
                }
                else
                {
                    end = mid;
                }

                if(target == nums[mid])
                {
                    return mid;
                }
            }

            if(target == nums[start])
            {
                return start;
            }

            if (start == nums.Length - 1)
            {
                int end2 = start;
                int start1 = 0;
            //    mid = (start1 + end2) / 2;
                while (start1 <= end2)
                {
                  

                    if (target < nums[mid])
                    {
                        end2 = mid - 1;
                    }

                    if (target > nums[mid])
                    {
                        start1 = mid + 1;
                    }
                    if (target == nums[mid])
                    {
                        return mid;
                    }
                    mid = (start1 + end2) / 2;
                }
            }

            if( target > nums[start])
            {
                int end1 = start - 1;
                start =0; 
                while(start < end1)
                {
                     mid = (start +end1)/ 2;

                     if(target < nums[mid])
                    {
                        end1 = mid-1;
                    }

                     if(target > nums[mid])
                    {
                        start = mid + 1;
                    }
                     if(target == nums[mid])
                    {
                        return mid;
                    }
                }
            }

            else
            {
                end = nums.Length - 1;
               
                while (start < end)
                {
                    mid = (start + end) / 2;

                    if (target < nums[mid])
                    {
                        end = mid - 1;
                    }

                    if (target > nums[mid])
                    {
                        start = mid + 1;
                    }
                    if (target == nums[start])
                    {
                        return mid;
                    }
                }
            }

            return -1;
        }
    }
}
