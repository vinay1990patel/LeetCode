using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CSharp
{

    // Design a class or method that can accpet the tpye one or more than one type untill the class or method declred
    // or instantiated by client code.

    class testGenric<T>
    {
        public static bool equals(T a, T b)
        {
            return a.Equals(b);
        }
    }



    public  class genricT
    {
        public static  bool equals<T>(T input1, T input2)
        {
            return input1.Equals(input2);
        }
    }



    class Anonymous { 

    // Anonymous Type

        public void Methods ()
        {
            var result = new { name = "ff", Age = 12 };
            Console.WriteLine(result.name);
            Console.WriteLine(result.Age);
        }

   
    }
}
