using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multithreadAndAsyncParallel_programming
{
    internal class AsyncProgramAndErrorHandling
    {

        public static async void GetDataFromCollection()
        {

            try
            {

                await GetDataData();
            }
            catch (InvalidOperationException)
            {
            }


        }

        public static async Task GetDataData()
        {
            for (int i = 0; i < 1000000; i++)
            {

                Console.WriteLine(i);
            }
        }

    }
}
