using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multithreadAndAsyncParallel_programming
{
     class SingleThread
    {

        public static void m1(object n)
        {
            for(int i =0; i<= Convert.ToInt32(n); i++)
            {
                Console.WriteLine("m1 :" + i);
            }
        }

        public static void m2()
        {
            for (int i = 0; i <= 5; i++)
            {
                if(i == 2)
                {
                    Console.WriteLine("Execution started");
                    Thread.Sleep(10000);
                    Console.WriteLine("Execution Completed");
                }

                Console.WriteLine("m2 :" + i);
            }
        }
        public static void m3()
        {
            for (int i = 0; i <= 5; i++)
            {
                Console.WriteLine("m3 :" + i);
            }
        }
        public static void m4()
        {
            for (int i = 0; i <= 5; i++)
            {
                Console.WriteLine("m4 :" + i);
            }
        }
    }
}
