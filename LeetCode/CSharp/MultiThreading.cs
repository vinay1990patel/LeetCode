using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace LeetCode.CSharp
{
    internal class MultiThreading
    {
        // which enables developers to write applications that can perform multiple tasks concurrently.

        /* 
         Foreground Threads: These threads are created using the Thread class in C# and are considered to be the main threads of an application. 
         They prevent the application from terminating until all foreground threads have completed their tasks. 
         A foreground thread can be created by calling the Thread.Start() method. 
        */

        /*
         Background Threads: These threads are also created using the Thread class in C#, 
         but they are considered to be the secondary threads of an application.
         They do not prevent the application from terminating, even if they are still running.
         A background thread can be created by calling the Thread.Start() method and then setting the IsBackground property of the thread to true before starting it.
         */


        Thread thread = new Thread(Numbers);
        
         public void InvokeThread()
        {
            thread.Start();
            
        }
       

        public static void Numbers()
        {
            int total = 0;


            for (int i = 0; i < 100000000; i++)
            {
                total++;
            }

        }




    }
}
