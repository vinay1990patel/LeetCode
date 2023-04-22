using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CSharp
{
    // Delegate is a type safe pointer

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
    }

}
