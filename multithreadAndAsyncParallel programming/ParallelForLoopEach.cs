using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multithreadAndAsyncParallel_programming
{
    internal class ParallelForLoopEach
    {
      
        public static void ParallelForLoopEachMethod()
        {
            List<int> listSample = Enumerable.Range(0, 100).ToList();
            Parallel.ForEach(listSample, new ParallelOptions() { MaxDegreeOfParallelism = 3 }, i =>
            {
                Console.WriteLine($"I count {i} Thread Used For {Thread.CurrentThread.ManagedThreadId}");
            });

           
        }
    }
}
