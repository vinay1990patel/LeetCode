using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class SomeOfInteger
    {
     
        public static void SomeOfIntegers()
        {
            int input = 123432;
            int sume = 0;
            int rem = 0;
            while(input >= 1)
            {
               rem = input % 10;

                input = input / 10;
                sume = sume+rem;
            }


            Console.WriteLine(sume);
        }

        public static int SomeOfIntegersUsingRecurtion(int number)
        {

           
         
            if (number is not 0)
            {
                return  (number % 10 + SomeOfIntegersUsingRecurtion(number / 10));
               

            }

            return 0;

           


        }

        public static void SomeOfIntegersUsingLinq()
        {
            int number = 123456;

           int sum = number.ToString().Select(x =>int.Parse(x.ToString())).ToArray().Sum();
        }
    }


}

