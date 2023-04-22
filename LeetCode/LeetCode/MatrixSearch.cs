using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LeetCode
{
    internal class MatrixSearch
    {


        public static int matrixSearch(int[,] matrix, int m, int target)
        {
            if (m == 0)
            {
                return 0;
            }


            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (matrix[i, j] == target)
                    {
                        Console.WriteLine("element found at:" + i + ":" + j);
                        return 1;
                    }
                }
            }

            return 0;


        }


        public static int matrixSearch(int[,] matrix, int target)
        {
            int start = 0;
            int row = 4;
            int col = 4;
            int end = row * col - 1;
            // int mid;
            int mid = start + (end - start) / 2;

            while (start <= end)
            {
                //  int mid1 = mid;
                int ele = matrix[mid / col, (mid % col)];

                if (ele == target)
                {
                    return 1;
                }
                if (ele < target)
                {
                    start = mid + 1;
                }
                else
                {
                    end = mid - 1;
                }
                mid = start + (end - start) / 2;
            }
            return 0;
        }  // O(lonm*n)

        public static bool matrixSearch(int[][] matrix , int target)
      {
            if(matrix.Length == 0)
            {
                return false;
            }

            for(int i = 0; i< matrix[0].Length; i++)
            {
                for(int j =0; j< matrix[0].Length; j++)
                {
                    if (matrix[i][j] == target) {
                       return true;
                    }
                }
            }

            return false;
        }


    }
}
