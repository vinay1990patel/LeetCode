using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LeetCode
{
    internal class FindFirstandLastPositionofElementinSortedArray
    {

        public static int[] firstAndLast(int[] nums , int target)
        {

          
            int i = 0;
            int j = 0;
            int left = 0;
            int right = nums.Length - 1;
          
            int l = -1;
            while (left <= right)
            {

                int mid = (left + right) / 2;
                if (target > nums[mid])
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }

                if (nums[mid] == target)
                {


                    l = mid;
                     


                }

                if(l != -1)
                {
                    i = l;
                    j = l;
                    
                    while(i-1 >= 0 && nums[i-1] == nums[i])
                    {
                        i--;
                    }
                    while (j  <= nums.Length -1 && nums[j+1] == nums[j])
                    {
                        j++;
                    }

                    return new int[] { i, j };
                }


               

              
               
            }

            return new int[] { -1, -1 };


        }
    }
}
