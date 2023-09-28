using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CSharp
{

    class Result
    {
       public int Add;
        public   int Sub;
    }
    internal class MultipleValueReturn
    {

     
         // using Class type
        public Result ReturnMultiPleValue(int a , int b)
        {
            var result = new Result
            {
                Add = a*b,
                Sub = a-b
            };

            return result;
        }

        // using Tuples
        public Tuple<int , int> ReturnMultiPleValue1(int a , int b)
        {
            Tuple<int, int> tuple = new Tuple<int, int>(a*b,a-b);
            return tuple;
        }

        // using C# Tuplse

        public (int add, int Sub) Method1(int a, int b)
        {
            return (a + b, a - b);
        }


        public static void Main(string[] args)
        {
            int a = 10;
            int b = 20;
            int add;
            int sub;


             // using out
            ReturnMultiple(a, b, out add, out sub);
            Console.WriteLine(add);
            Console.WriteLine(sub);

            // using ref
            ReturnMultipleUsingRef(a, b, ref add, ref sub);
            Console.WriteLine(add);
            Console.WriteLine(sub);


        }

        // using out
        public static void ReturnMultiple(int a, int b , out int add, out int sub )
        {
            add = a + b;
            sub = a - b;

        }

        // using ref
        public static void ReturnMultipleUsingRef(int a, int b, ref int add, ref int sub)
        {
            add = a + b;
            sub = a - b;
            
        }
    }
}
