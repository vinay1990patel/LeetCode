using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LeetCode
{
    internal class Sqrt_x_
    {

        public static int  SqureRoot (int x)
        {

            Int64 start = 0;
            Int64 end = x;
            Int64 mid ;
            Int64 answer = -1;
           
            while (start <= end)
            {
                mid = (start + end) / 2;

                Int64 squreroot = (mid * mid);

                if (squreroot > x)
                {
                    end = mid-1;
                }
                if(squreroot < x)
                {
                    answer = Convert.ToInt32( mid);
                    start = mid+1;
                }
                if(squreroot == x)
                {
                    answer =  mid;
                }
            }

            return (int) answer;
        }

    }
}
