using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multithreadAndAsyncParallel_programming
{
    internal class MultiThread
    {

        public static void m1()
        {
            Console.WriteLine("Method 1 started using :" + Thread.CurrentThread.Name);
            Console.WriteLine("Method 1 Ended using :" + Thread.CurrentThread.Name);
            for (int i = 0; i <= 5; i++)
            {
                Console.WriteLine("m1 :" + i);
            }
            Console.WriteLine("Method 1 Ended using :" + Thread.CurrentThread.Name);
        }

        public static void m2()
        {

            Console.WriteLine("Method 1 started using :" + Thread.CurrentThread.Name);
            
            for (int i = 0; i <= 5; i++)
            {

                if (i == 2)
                {
                    Console.WriteLine("Execution started");
                    Thread.Sleep(10000);
                    Console.WriteLine("Execution Completed");
                }

                Console.WriteLine("m2 :" + i);
            }

            Console.WriteLine("Method 1 Ended using :" + Thread.CurrentThread.Name);
        }
        public static void m3()
        {


            Console.WriteLine("Method 1 started using :" + Thread.CurrentThread.Name);

            for (int i = 0; i <= 5; i++)
            {
                Console.WriteLine("m3 :" + i);
            }

            Console.WriteLine("Method 1 Ended using :" + Thread.CurrentThread.Name);
        }
       
    }
}
