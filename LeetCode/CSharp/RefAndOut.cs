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

        // Out => use as out put paramenter inililozation is must before coltrol leave the method . It is not compulsory to initialize a parameter or argument before it is passed to an out.

        public static void Sum(in int a, in int b, out int x)
        {
           x= a + b;
        }


        // Ref is use as input and output parameter , The parameter or argument must be initialized first before it is passed to ref.
        public static void increment(ref int i)
        {
            i++;
        }


        // They behave same at complie time but diferent at run time. so ref and out can not be overloaded. in same function
    }
}
