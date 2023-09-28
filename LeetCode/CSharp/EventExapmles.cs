using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CSharp
{

   
    public class EventExapmles
    {


        public event Action<object,string> EventeeXample;


        public void raiseEevnt(string name)
        {
            EventeeXample?.Invoke(this,name);
        }
    }


    public class Client
    {
        public void CunsumeEvents()
        {
           var eventExample = new EventExapmles();
            eventExample.EventeeXample += handler;
            eventExample.raiseEevnt("vinay");
            
        }

        private void handler(object arg1, string arg2)
        {
            Console.WriteLine(arg2);
        }

        public static void handler()
        {
            Console.WriteLine("hi");
        }


    }
}
