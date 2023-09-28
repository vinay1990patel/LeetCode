using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CSharp
{
    internal class OrderSubString
    {

      public  static int OrderSubStrings(string Name)
        {

            int count = 0;

            string[] output = new string[(Name.Length) * (Name.Length - 1)];

            string resut = string.Empty;

            for (int i = 0; i <= Name.Length; i++)
            {
                for (int j = 0; j <= Name.Length - i; j++)
                {

                    Console.WriteLine(Name.Substring(j, i));

                    resut = resut +" "+ Name.Substring(j, i);
                }
            }

            var result = string.Join(" ", resut.Split(' ').Distinct());

         return   result.IndexOf(Name)+1;

           
        }
    }
}