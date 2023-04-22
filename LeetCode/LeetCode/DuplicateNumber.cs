using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LeetCode
{
    internal class DuplicateNumber
    {

        public static bool ContainsDuplicate()
        {

           int[]  nums = { 1, 2, 3, 4 };
            //int count = 0;
            //for (int i = 0; i < nums.Length; i++)
            //{

            //    for (int j = 0; j < nums.Length; j++)
            //    {
            //        if (nums[i] == nums[j])
            //        {
            //            count++;

            //        }
            //    }


            //    if (count > 1)
            //    {
            //        return true;
            //    }

            //    count =0;
            //}

            //return false;

            Array.Sort(nums);
            for (int i = 0; i < nums.Length-1; i++)
            {
                int element = nums[i];

                if (nums[i+1] == element)
                {
                    return true;
                }


            }

            return false;
        }
    }
    }

