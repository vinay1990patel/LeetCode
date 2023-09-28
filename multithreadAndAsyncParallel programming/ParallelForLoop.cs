using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multithreadAndAsyncParallel_programming
{
    internal class ParallelForLoop
    {
        public static void ParallelForLoopMethod() {

            Parallel.For(0, 10, new ParallelOptions() { MaxDegreeOfParallelism = Environment.ProcessorCount} , x =>
            {

             
                Console.WriteLine($"Value of X {x},  Thred Id {Thread.CurrentThread.ManagedThreadId} And Total Processor Count {Environment.ProcessorCount}");
            });

        }
    }
}
