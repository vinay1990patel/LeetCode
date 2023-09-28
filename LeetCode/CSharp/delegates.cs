using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CSharp
{
    // Delegate is a type safe pointer. in which we can pass method as a parameter. 



    delegate void HelloDelegate(int a,  int b);

    delegate void MulticastDelegates(int a,  int b);


    // Multicast delegate has reference to more than one function. when you invoke multicast delegate all function 
    // pointing to multicast delegates got invoked.

    // Multi cast delegate is use to implement obsrover design pattern.
    public class delegates
    {
       public static void Add(int a , int b)
        {
            Console.WriteLine(a+b);
        }

        public static void Div(int a, int b)
        {
            Console.WriteLine(a / b);
        }
        public static void Del(int a, int b)
        {
            Console.WriteLine(a - b);
        }
        public static void Mul(int a, int b)
        {
            Console.WriteLine(a * b);
        }




        public static void ClientDeleGates()
        {
            HelloDelegate helloDelegate1 = new HelloDelegate(delegates.Add);
            helloDelegate1(2, 4);

            MulticastDelegate  DL1, DL2, DL3,DL4;

            DL1 = new MulticastDelegates(delegates.Add);
            DL2 = new MulticastDelegates(delegates.Div);
            DL1 = new MulticastDelegates(delegates.Del);
            DL2 = new MulticastDelegates(delegates.Div);


            // Ananmous Delegates
            /* Delegates poiting to a method without name of method is callled ananymous delegates*/

            HelloDelegate ananymous = delegate (int a, int b)
            {
                Console.WriteLine(a + b);
            };

            ananymous(2, 3);

        }
    }



   

}
