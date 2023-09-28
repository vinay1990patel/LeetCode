using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CSharp
{
    internal class ParamsKeyWord
    {

        public static void Main()
        {
            int y = Sum(1, 2, 3, 4, 5,7);  //  we can pass any number of arguemnt.
        }


        // Params key words used as which can take any number of arguement as input.but it should be in last after non params parameter
        public static int Sum( params int[] numbers )
        {
            int total = 0;
            foreach (int i in numbers)
            {
                total += i;
            }
            return total;
        }
    }
}
