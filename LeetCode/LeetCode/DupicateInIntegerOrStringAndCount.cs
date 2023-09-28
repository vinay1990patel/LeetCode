using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LeetCode
{
    abstract class DupicateInIntegerOrStringAndCount
    {
       

        public static void DuplicateItegerAndCount()
        {
            int[] array = { 1, 2, 43, 5, 4, 5, 6, 4 };
            int count = 0;
            Dictionary<int, int> map = new Dictionary<int, int>();
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i+1; j < array.Length; j++)
                {
                    if (array[i] == array[j])
                    {
                        if (map.ContainsKey(array[i]))
                        {
                            continue;
                        }
                        count++;
                        map.Add(array[i], count + 1);
                    }
                }
            }

            foreach(var r in map)
            {
                Console.WriteLine(r.Key +"is : " + r.Value +"times");
            }

          

        }

        public static void DuplicateWordInString()
        {
            string inputString = "vinay vinay patel kumar vinay patel";
            string[] intputArray = inputString.Split(' ');
            Dictionary<string, int> map = new Dictionary<string, int>();
            int count = 0;
            for(int i =0; i <intputArray.Length; i++)
            {
                for (int j = i + 1; j < intputArray.Length; j++)
                {
                    if (intputArray[i] == intputArray[j])
                    {

                        if (map.ContainsKey(intputArray[i])) {
                            count++;
                           continue;
                        }
                        
                        count++;

                        map.Add(intputArray[i].ToString(), count+1);
                    }
                    count = 0;
                }
            }

            foreach(var i in map)
            {
                Console.WriteLine(i.Value);
            }
        }

        public static void DuplicateCharInString()
        {
            string inputString = "vinay kumar patel";
            int count = 1;
            Dictionary<string, int> keyValuePairs = new Dictionary<string, int>();
            for (int i = 0; i <inputString.Length; i++)
            {
               for(int j = i + 1;j < inputString.Length; j++)
                {
                   
                    if (inputString[i] == inputString[j])
                    {
                        count++;

                       

                        keyValuePairs.Add(inputString[i].ToString(), count+1);
                       
                        
                    }

                 
                }

              foreach(var r in keyValuePairs)
                {
                    Console.WriteLine(r.Key +"==="+ r.Value);
                }

              
            }
        }
    }
}
