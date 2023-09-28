using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LeetCode
{
    internal class OnlyOnceOccured
    {



        public static void FindOnlyOnceOccurance()
        {

            int[] input = { 1, 4, 3, 2, 3, 4, 5, 6 };
            int i = 0;
            int j = 0;
            int count = 0;
            Dictionary<int , int > keyValues = new Dictionary<int , int>();
            for ( i = 0; i < input.Length; i++)
            {
                for( j =0; j < input.Length; j++)
                {

                    if(i == j)
                    {
                        continue;
                    }
                    if (input[i] == input[j])
                    {

                        break;
                    }
                
                }

                count = 0;

                if (input.Length == j)
                {
                    Console.WriteLine(input[i]);
                }


            }
        }
    }
}
