using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LeetCode
{
    internal class PalimDromeOfintegerAndString
    {

    
        public static void IntergerPlimdrome()
        {
            int nums = 1221;
            int d = nums;
            int sum=0;
            while (d > 0){

                int rem = d % 10;
                d = d / 10;
                sum = sum * 10 + rem;

            }

            if (nums == sum)
            {
                Console.WriteLine("ok");
            }
        }

        public static void StringPalimdrome() {
            string inputstring = "MoM";
            char[] input1 = inputstring.ToCharArray();
            string oupput = null;
            int lenght = inputstring.Length;
            for(int i = 0; i < input1.Length; i++)
            {
                oupput =oupput + input1[lenght - i - 1].ToString();
            }

            if (inputstring.Equals(oupput))
            {
                Console.WriteLine("vinay");
            }
        }

    }
}
