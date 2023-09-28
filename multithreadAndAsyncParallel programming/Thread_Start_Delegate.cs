using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace multithreadAndAsyncParallel_programming
{
    internal class Thread_Start_Delegate
    {

        // 
        public static void Main()
        {
          ThreadStart obj = new ThreadStart(new ParameterizedThreadStart(method(int q)));

            Thread thread = new Thread(new ParameterizedThreadStart(method));
            thread.Start(10);
        }

      

         
        
         static void  method(object a)
        {
            Console.WriteLine( "For thread Delegates");
          
        }
    }
}
