using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multithreadAndAsyncParallel_programming
{
    internal class ParallelInvoke
    {
        public static void ParallelInvokeMethod()
        {
        
            Parallel.Invoke(
                Method1,
                Method2,
                Method3,
            delegate ()
            {
                Method4();
            },

            () => Method5(),
            () => Method6()
                ) ;


        }

        static void Method1()
        {
            Console.WriteLine("Method1");
        }
        static void Method2()
        {
            Console.WriteLine("Method2");
        }
        static void Method3()
        {
            Console.WriteLine("Method3");
        }
        static void Method4()
        {
            Console.WriteLine("Method4");
        }
        static void Method5()
        {
            Console.WriteLine("Method5");
        }
        static void Method6()
        {
            Console.WriteLine("Method6");
        }
    }
}
