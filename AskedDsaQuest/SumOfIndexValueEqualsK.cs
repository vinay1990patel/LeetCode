using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AskedDsaQuest
{
    internal class SumOfIndexValueEqualsK
    {
        public static void GetSumOFTwoIndexValueEqualKAndReturnIndexs(int[] Array, int k)
        {
            int s = 0;  // 2 7 11 15                            9
            int e = 1;
            
           while(e < Array.Length)
            {
                int sum = 0;
                sum += Array[s] + Array[e];
                if (sum == k)
                {
                    Console.WriteLine("Sum Index of K Value" + s);
                    Console.WriteLine("Sum Index of K Value" + e);
                    return;
                }
                e++;
                s++;
               
            }

        

            }
        }
    }

