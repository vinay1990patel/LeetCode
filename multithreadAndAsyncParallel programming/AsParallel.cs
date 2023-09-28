using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multithreadAndAsyncParallel_programming
{
    internal class AsParallel
    {
       public static void AsParallelForAll()
        {
            List<int> listSample = Enumerable.Range(0, 10).ToList();
            listSample.AsParallel().ForAll(x =>
            {
                if(x % 2 == 0)
                {
                    Console.WriteLine($"x : {x}");
                }

            });
        }
    }
}
