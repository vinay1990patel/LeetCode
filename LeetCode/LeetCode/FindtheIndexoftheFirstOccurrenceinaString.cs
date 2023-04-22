using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LeetCode
{
    internal class FindtheIndexoftheFirstOccurrenceinaString
    {
        public static int StrStr(string haystack, string needle)   // vinaypatel el
        {
           string result = string.Empty;
            int index = -1;
            for (int i = 0; i < haystack.Length; i++)
            {
                for (int j = 0; j < needle.Length; j++)
                {
                    if (needle[i] == haystack[j])
                    {

                        result = result + haystack[i];
                        //   continue;
                    }

                    haystack = haystack.Substring(i + 1);
                }

            }

                //if (result == needle)
                //{
                //    return index = i - needle.Length - 1;
                //}




                return -1;
        }
    }
}
