using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CSharp
{
     
    public delegate void eventNotification(); // delegate
    public class eventProgram
    {
       
        
      
        
        
        
        public event eventNotification processCompleted; // event





        public static void eventHandler()
        {
            Console.WriteLine("Process completed");
        }

        public void startProcess()
        {
            Console.WriteLine( "process Started");
        }

        public void stopProcess()
        {
            processCompleted?.Invoke();
          
        }
    }

   public class eventClient
    {
       public static void Main()
        {
            eventProgram eventProgram1 = new eventProgram();
            eventProgram1.processCompleted += eventProgram.eventHandler;
            eventProgram1.startProcess();
        }

    }
}
