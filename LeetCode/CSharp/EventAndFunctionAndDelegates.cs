using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CSharp
{

   
    internal class EventAndFunctionAndDelegates
    {

        // Event    => Event are useful when you want loosely coupled one to many notification of state changes  Event is notification mechanishm tha depend on delegets.

        /*
          In QAC RA we have handlers of delegate type to trigger the event when task is finished.
          and event hander when task is started/ finished/ onError/
       
        we are using 2 types of event --
        -- CLR Events::
             
              -- CLR events are a language feature in C# and .NET that enable communication between objects within the same process
              --They are implemented using delegates and the event keyword. Publishers define an event, and subscribers attach event handlers to it. When the event is raised, 
                the attached handlers are invoked.

        -- Domain Events:: Need to read more.



         */



        //          => we can not create event without delegets.
        //          => Event is like a wrapper over delegates which provides secuirty.

        // Function => Delegates => event
        // event depends on delegates and delegates depends on funtion.


        public static void Main()
        {
            var publisher = new Publisher();

            // Subscriber class subscribes in its constructor
            var subscriber = new Subscriber(publisher);

            // Inline handler (store reference if you want to unsubscribe later)
            EventHandler inlineHandler = (s, e) => Console.WriteLine("Inline handler called.");
            publisher.MyEvent += inlineHandler;

            Console.WriteLine("Raising event #1");
            publisher.RaiseEvent();
            // Output:
            // Event handled!
            // Inline handler called.

            // Unsubscribe the inline handler
            publisher.MyEvent -= inlineHandler;

          
        }


        public class Publisher
        {
            public event EventHandler MyEvent;

            public void RaiseEvent()
            {
                MyEvent?.Invoke(this, EventArgs.Empty);
            }
        }

        public class Subscriber
        {
            public Subscriber(Publisher publisher)
            {
                publisher.MyEvent += HandleEvent;
            }

            private void HandleEvent(object sender, EventArgs e)
            {
                Console.WriteLine("Event handled!");
            }
        }



    }




    




}
