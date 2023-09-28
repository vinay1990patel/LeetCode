using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LeetCode
{
    public class ReverseStringAndInteger
    {
       public static void ReverseWordsOfString()
        {
            string inputString = "vinay kumar patel";
            string[] inputArray = inputString.Split(' ');
            string sum = null;
           
            for(int i =0; i <inputArray.Length; i++)
            {
              for(int j =0; j < inputArray[i].Length; j++)
                {
                    string s = inputArray[i];
                    int lenght = s.Length;
                    sum  += s[lenght - 1 - j].ToString();
                }

                sum = sum + " ";
            }
            

        }


        public static void ReverseWord()
        {
            string inputString = "vinay kumar patel";
            string newString = string.Empty;
            string newString1 = string.Empty;
            for (int i = inputString.Length - 1; i >= 0; i--)
            {
                newString = newString + inputString[i];

            }

            string[] sns = newString.Split(" ").ToArray();
            
            for(int j = sns.Length-1; j>=0; j--)
            {
              
                newString1 = newString1 + sns[j] +" ";
            }
           
        }
    }

}

