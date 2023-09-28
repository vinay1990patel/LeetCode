using LeetCode.CSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LeetCode
{
    internal class Class1
    {

        public static int solve()
        {
            // Just write your code below to complete the function. Required input is available to you as the function arguments.
            // Do not print the result or any output. Just return the result via this function.
            // -98, 54, -52, 15, 23, -97, 12, -64, 52, 85 0,2,9 1,2,3,2,1

            List<int> A = new List<int> { 1,1,1};
            int B = 2;
            int counter = 0;
            for (int i = 1; i < A.Count; i++)
            {
                
                    if (A[i-1] + A[i] == B)
                    {

                        counter++;

                    }
                



            }
            return counter;

        }
    }
}
