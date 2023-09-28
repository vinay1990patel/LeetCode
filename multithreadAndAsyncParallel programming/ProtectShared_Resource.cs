using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multithreadAndAsyncParallel_programming
{
    internal class ProtectShared_Resource
    {


      public static  object _obj = new object();

        public static void ProtectSharedThread()
        {
            int sum = 0;

            for(int i =0; i < 1000; i++)
            {
                Interlocked.Increment(ref sum); // 1 => Good in performance compare to lock oused for increment or decrement

                lock (_obj)                    // 2  =>   use lock properly
                {
                    sum++;
                }


                Monitor.Enter(_obj);
                {
                    try
                    {
                        sum++;
                    }
                    catch { 
                    }
                    finally
                    {
                        Monitor.Exit(_obj);
                    }
                }
            
            }

           
        }
    }
}
