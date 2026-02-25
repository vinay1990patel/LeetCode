using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LeetCode.LeetCode2025
{

    /*
     1. Print the subarray of given staring and eding index
     2. Print all the subArray
     3. Find the subarray sum if have equal to k;
     4. Print the Smallest subarray which contains minimum and max element.
     5. prefix Array Sum
     6. prefix Array Sum optamized
     7. prefix Array Sum in same array.
     8. Max Sub Array Sum
     9. Total of All possile sub array. 
     10. Siliding Windows  => Given an array og lenght N . print the max subarray sum for the subarray with lenght k
     */
    internal class SubArrayAndSubArraySum
    {
        //2. Print All the subArray
        public static void PrintAllSubArray(int[] array)
        {

            for (int s = 0; s < array.Length; s++)
            {
              
                for (int e = s; e<array.Length; e++)
                {

                    for(int i = s; i<e; i++)
                    {
                        Console.WriteLine(array[i]);
                    }
                    Console.Write("\n");

                }
              
            }
        }

        //  3. Find the subarray sum if have equal to k;
        public static void SubArraySumM(int[] array, int k)
        {

            for (int s = 0; s < array.Length; s++)
            {
              
                for (int e = s; e < array.Length; e++)
                {
                    int sum = 0;

                    for (int i = s; i < e; i++)
                    {
                       sum += array[i]; 
                    }
                    Console.Write("\n");
                    if (k == sum)
                    {
                        Console.WriteLine("K found");
                        break;
                    }
                }
            }

        }

        //  4.Print the Smallest subarray which contains minimum and max element.
        public static void SmallestSubArrayWhichContainsMinAndMaxElement(int[] array, int min , int max) {
            
        }
        //5. Sub Array Sum prefix

        public static void SubArraySum(int[] Array)
        {
            int[] pf = new int[Array.Length] ;
            int sum = 0;

            for(int i =0; i < Array.Length; i++)
            {
                for(int j =i; j <=i; j++)
                {
                  sum = sum + Array[j];
                }

                pf[i] = sum;
            }

            for(int i = 0; i < pf.Length; i++)
            {
                Console.WriteLine(pf[i]);
            }
        }
        
     //   6. Sub Array Sum optamized
        public static void SubArraySumOptamized(int[] Array)
        {
            int[] pf = new int[Array.Length];
            pf[0] = Array[0];
           

            for (int i = 1; i < Array.Length; i++)
            {
                pf[i] = pf[i - 1] + Array[i]; 
            }

            for (int i = 0; i < pf.Length; i++)
            {
                Console.WriteLine(pf[i]);
            }
        }


        // 7. prefix Array Sum in same array.

        public static void PrefixArraySumInSameArray(int[] Array)
        {
            for(int i = 1; i<Array.Length; i++)
            {
                Array[i] = Array[i - 1] +Array[i];
            }

            for(int j =0; j < Array.Length; j++)
            {
                Console.WriteLine(Array[j]);
            }
        }

        //   8. Max Sub Array Sum 1,3,2,4,5  output  1,4,6,19,15

        public static void MaxSubArraySum(int[] array)
        {
         
            int result = array[0];
            for (int s = 0; s < array.Length; s++)
            {
               
                for (int e =s; e <array.Length; e++)
                {
                    int sum1 = 0;
                    for (int k = s; k<=e; k++)
                    {
                        sum1 += array[k];
                    }
                    Console.WriteLine(sum1);

                    result = MaxtMethod( result , sum1);
                }

            }

            Console.WriteLine("Max of sub array sum :"+ result);
        }


        public static void MaxSubArraySumUsinPrefixSum(int[] array)
        {

            int result = array[0];
            for (int s = 0; s < array.Length; s++)
            {

                int sum1 = 0;
                for (int e = s; e < array.Length; e++)
                {


                    sum1 += array[e];
                    result = MaxtMethod(result, sum1);
                }

            }

            Console.WriteLine("Max of sub array sum :" + result);
        }

       // 9. Total of All possile sub array.

          public static void TotalOfAllPossibleSubArray(int[] array)
        {
            int result = 0;
            for(int s = 0; s <array.Length; s++)
            {
                for(int e = s; e < array.Length; e++)
                {
                    for(int k= s; k<=e; k++)
                    {
                        result += array[k];
                    }
                  
                }
            }
            Console.WriteLine("Total of Sub Array:" +result);
        }

        // 10. Siliding Windows  => Given an array og lenght N . print the max subarray sum for the subarray with lenght k


          public static void MaxSubArraySumOfGivenLenghtRang_SlindingWindow(int[] array)
        {
            int k = 5;
            int result = int.MinValue;
            int s =0;
            int e = k - 1;
            int sum = 0;
            while (e < array.Length)
            {
                for(int i =s; i <=e; i++)
                {
                    
                    result += array[i];
                }
                result = MaxtMethod(result, sum);
                e++;
                s++;
            }

            Console.WriteLine("Max Sum of Sub Array Of a window length :" + result);

        }
        public static int MaxtMethod(int max, int sum)
        {
            if(max < sum)
            {
               max = sum;
            }

            return max;
        }
    }
}
