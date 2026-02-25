using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LeetCode.LeetCode2025
{
    internal class ArrayAndSorting
    {

        /*
           1. Find the nobel element in the Array : Noble the element have is equals to the count of smaller element than element

            
         
         */


        //  1. Find the nobel element in the Array : Noble the element have is equals to the count of smaller element than element

        public static void NobelElementBruteForce(int[] intputArray)
        {
            Array.Sort(intputArray);
            int count = 0;
            int result = 0;
            for (int i = 0; i < intputArray.Length; i++)
            {

                for (int j = 0; j < intputArray.Length; j++)
                {


                    if (intputArray[j] < intputArray[i])
                    {
                        count++;
                    }
                }

                if (intputArray[i] == count)
                {
                    result++;
                }
            }

            Console.WriteLine("Noble count is :" + result);
        }
    }

}