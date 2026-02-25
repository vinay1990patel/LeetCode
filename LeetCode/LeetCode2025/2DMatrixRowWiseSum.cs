using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LeetCode2025
{
    internal class _2DMatrixRowWiseSum
    {

        /*
           1. Sum row isw
           2. sum col wise
           3. Given N*N matrix print the diagonal element from left to wirte.
           4. Given N*N matrix print the diagonal element from lEFT to RIGHT.
           5. Print all the Anit Diagonal of a non-squre matrix
           6. Given Squire Matrix find the transpose
           7.
           
           * Matrix Multipication *
         */
        public static void RowWiseSomeOfMatrix(int[,] array)  //TC  => O(i*j)  Sp => O(1)
        {
            int row = array.GetLength(0);
            int col = array.GetLength(1);

            for (int i = 0; i < row; i++)
            {
                int sum = 0;
                for (int j = 0; j < col; j++)
                {
                    sum = sum + array[i, j];
                }

                Console.WriteLine("Some Of Row:" + i + 1 + ":" + sum);
            }
        }

        public static void ColWiseSomeOfMatrix(int[,] array)  //TC  => O(i*j)  Sp => O(1)
        {
            int row = array.GetLength(0);
            int col = array.GetLength(1);

            for (int i = 0; i < col; i++)
            {
                int sum = 0;
                for (int j = 0; j < row; j++)
                {
                    sum = sum + array[j, i];
                }

                Console.WriteLine("Some Of Col:" + i + 1 + ":" + sum);
            }
        }

        // 4. Given N*N matrix print the diagonal element from RIGHT to LEFT.

        public static void PrintTheDiagonalElementFromLeftToRight(int[,] array) // TC O(n) //O(1)
        {
            int i = 0;
            int j = array.GetLength(1) - 1;
            while (i < array.GetLength(0) && j >= 0)
            {
                Console.WriteLine(" Anti Daigonal  Element:" + array[i, j]);
                i++;
                j--;
            }

        }

        //  5. Print all the Anit Diagonal of a non-squre matrix
        public static void PrintAllAntiDiagonalNon_SqureMatrix(int[,] array)
        {
            int m = array.GetLength(0);
            int n = array.GetLength(1);

            for(int col =0; col <m; col++)
            {
                int i = 0;
                int j = col;
                while (i < n  && j >= 0)
                {
                    Console.Write(array[i,j]);
                        i++;
                        j--;
                }
                Console.Write('\n');
            }
            for (int row = 1; row < n; row++)
            {
                int i = row;
                int j =m-1;
                while (i < n  && j >= 0)
                {
                    Console.Write(array[i, j]);

                    i++;
                    j--;
                }
                Console.Write('\n');
            }
        }

        public static void FindTheTransposeOfMatrix(int[,] array)
        {
            int row = array.GetLength(0);
            int col = array.GetLength(1);
            for(int i = 0; i < row; i++)
            {
                for(int j = i+1;  j < row; j++)
                {
                     int temp = array[i,j];
                     array[i,j] = array[j,i];
                     array[j,i] = temp;

                    Console.Write(array[i,j]);

                }

                Console.Write("\n");
            }
        }
    }
}
