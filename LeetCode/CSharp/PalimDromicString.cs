using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CSharp
{
    internal class PalimDromicString
    {


       
      public  static int solve(String S1, String S2)
        {
            // You must complete the logic for the function that is provided
            // before compiling or submitting to avoid an error.
            // Write your code here
            int l1 = S1.Length, l2 = S2.Length;
            int answer = int.MaxValue;
            for (int i = 0; i < l1 - l2 + 1; i++)
            {


                string temp = S1.Substring(0, i) + S2
                              + S1.Substring(i + l2);
                int cost = 0;


                for (int j = i; j < i + l2; j++)
                {

                    if (S1[j] != temp[j])
                        cost++;
                }
                int z = 0;


                for (int j = 0; j < Math.Ceiling(l1 / 2.0);
                     j++)
                {


                    if ((j < i || j >= i + l2)
                        && temp[j] != temp[l1 - j - 1])
                        cost++;


                    else if (temp[j] != temp[l1 - j - 1]
                             && (l1 - j - 1 < i
                                 || l1 - j - 1 >= i + l2))
                        cost++;


                    else if (temp[j] != temp[l1 - j - 1])
                    {
                        z = 1;
                        break;
                    }
                }
                if (z == 0)
                    answer = Math.Min(answer, cost);
            }
            if (answer == int.MaxValue)
            {
                return -1;
            }
            return answer;
        }

    }
}
