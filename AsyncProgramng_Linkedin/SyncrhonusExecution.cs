using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsyncProgramng_Linkedin
{
    internal class SyncrhonusExecution
    {
        public static string Synchronous(){
            Console.WriteLine("processing Started");
            Thread.Sleep(3000);
            Console.WriteLine("processing completed");

            Console.WriteLine(System.Threading.Thread.CurrentThread.ManagedThreadId);

            return "Returned task";
    }
    }
}
