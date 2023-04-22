using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LeetCode
{
    internal class ArrayShortClass
    {

        // 5,2,3,1
        public static int[] arrayShort(int[] nums, int l =0, int r =0)
        {

            r = nums.Length;
            int mid = (l + r) / 2;
            int[] result = new int[nums.Length];
            if(l < r)
            {
                arrayShort(nums, l, mid);
                arrayShort(nums, mid + 1, r);

              result =     merge(nums, l, mid + 1, r);
               
            }

            return result;

        }

        public static int[] merge(int[] num , int l,int  mid, int r)
        {
            int n1 = mid - l + 1;
            int n2 = r - mid;

            int[] temp1 = new int[n1];
            int[] temp2 = new int[n2];

            for(int i =0; i < temp1.Length; i++)
            {
                temp1[i] = num[l + i];
                
            }

            for(int i =0; i < temp2.Length; i++)
            {
                temp2[i] = num[mid + 1 + i];
            }

            return num;
        }

    }
}
