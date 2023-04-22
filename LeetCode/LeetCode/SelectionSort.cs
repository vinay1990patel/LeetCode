using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LeetCode
{
    internal class SelectionSort
    {

        public static void SelectionSortMethod(int[] input )
        {
            // 8,1,4,6,2,5
          
            for (int i = 0; i < input.Length; i++)
            {
                int min = i;
                for (int j = i+1; j < input.Length; i++)
                {

                    if (input[j] < input [min])
                    {
                           min = j;

                     
                     
                    }

                   
                }
            }
        }
    }
}
