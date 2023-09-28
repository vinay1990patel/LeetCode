using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CSharp
{
    internal class RefAndOut
    {

        // by using ref and out you can pass value by reference.
        // Ref is use as input and output parameter, out can be use as out put parameter , both can be use to return multiple value.


        public static void Main()
        {
            int a = 10; // REF => The parameter or argument must be initialized first before it is passed to ref.
            int b;      // OUT => No need to initialize parameter before passing it


            RefAndOut.Sum(ref a, out b);
        }

        public static void Sum(ref int a, out int b)
        {
            b = 10;  // OUT => parameter must be initialized before leaveing the controll leave the method
                     // REF => initialized not neccessory before control leave the method
        }




      



        // They behave same at complie time but diferent at run time. so ref and out can not be overloaded. in same function
    }
}
