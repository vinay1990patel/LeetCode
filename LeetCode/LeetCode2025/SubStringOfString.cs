using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LeetCode2025
{
    internal class SubStringOfString
    {

        /*
         1. Print All sub string of a string
         2. Check is string is Palimdrome
         3. Larget lenght of palimodromic substring
         4. Toggle the char of a string
         
         */
        public static void SubStringOfStringMethod(string input)
        {
            for (int s = 0; s < input.Length; s++) {
                for (int e = 0; e < input.Length; e++) {
                    for (int j = s; j <=e; j++) {

                        Console.Write(input[j]);

                      
                    }
                    Console.Write("\n");
                }
            }
        }


        public static bool PalimDromeString(string inputString)  // vinay
        {
            int s = 0;
            int e = inputString.Length - 1;

           while(s <= e)
            {
                if (inputString[s] != inputString[e])
                {
                    //Console.WriteLine("String is not Palimdorme");
                    return false;
                }
                 s++;
                 e--;
            }

            //Console.WriteLine("String Is PalimDome :" + inputString);
           return true;
        }


        public static void LargestSuStringPalimdrome(string input)
        {
            int length = int.MinValue;
            for (int s = 0; s < input.Length; s++)
            {
                for (int e = 0; e < input.Length; e++)
                {
                    string result = string.Empty;


                    for (int j = s; j <= e; j++)
                    {
                        result = result + input[j];
                    }

                    if (PalimDromeString(result))
                    {
                        length = Math.Max(length, result.Length);
                    }
                }
            }

            Console.WriteLine("Max Lenght of SubString Is :" + length);


        }

        public static void CharToggleInStringMethod(string chars)
        {
            for (int i = 0; i < chars.Length; i++)
            {
                if (chars[i] >= 65 && chars[i] <= 90)
                {
                    Console.WriteLine((char)(chars[i] + 32));
                }
                else
                {
                    Console.WriteLine((char)(chars[i] - 32));
                }
            }
        }
    }
}
