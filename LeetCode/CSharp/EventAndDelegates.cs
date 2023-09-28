using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CSharp
{

   
    internal class EventAndDelegates
    {

        // Event  => Event is notification mechanishm tha depend on delegets.
        //          => we can not create event without delegets.
        //          => Event is like a wrapper over delegates which provides secuirty.

        // Function => Delegates => event
        // event depends on delegates and delegates depends on funtion.


        public static void Main()
        {
            ProcessBusinessLogic bl = new ProcessBusinessLogic();
            bl.ProcessCompleted += bl_ProcessCompleted; // register with an event
            bl.StartProcess();
        }


        // event handler
        public static void bl_ProcessCompleted()
        {
            Console.WriteLine("Process Completed!");
        }
    }

    public delegate void Notify();  // delegate

    public class ProcessBusinessLogic
    {
        public event Notify ProcessCompleted; // event

        public void StartProcess()
        {
            Console.WriteLine("Process Started!");
            // some code here..
            OnProcessCompleted();
        }


        protected virtual void OnProcessCompleted()
        {
            ProcessCompleted?.Invoke();
        }



    }




    




}
