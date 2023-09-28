using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CSharp
{
    internal class GeniricDelegates
    {
        public delegate double AddNumber1Delegate(int no1, float no2, double no3);
        public delegate void AddNumber2Delegate(int no1, float no2, double no3);
        public delegate bool CheckLengthDelegate(string name);
        static void Main(string[] args)
        {

            // By using custom delegate

            //AddNumber1Delegate obj1 = new AddNumber1Delegate(AddNumber1);
            //double Result = obj1.Invoke(100, 125.45f, 456.789);
            //Console.WriteLine(Result);

            /******************* Func Delegate *********************************/


            /*
             
             The Func Generic Delegate in C# is used when ever your delegate returns some value, 
             whether by taking any input parameter or not. In our example,
             the AddNumber1 method takes some input and returns one output. So,
             the AddNumber1 method signature is matched with the Func generic delegate signature. 
             So, here, instead of creating our own delegate to invoke the AddNumber1 method, 
             we can use the Func generic delegate to invoke the AddNumber1 method as shown in the below code.
             
             */



            Func<int, float, double,double> obj1 = new Func<int, float, double, double>(AddNumber1);

            double result = obj1.Invoke(10, 10.0f, 102.4);

            Console.WriteLine(result);





            /****************** Action ****************************/


            /*
             
            The Action Generic Delegate in C# is used whenever your delegate does not return any value, 
            whether by taking any input parameter or not.
             
             */


            Action<int, float, double> action = new Action<int, float, double>(AddNumber2);
            Console.WriteLine(action.Invoke);


            //AddNumber2Delegate obj2 = new AddNumber2Delegate(AddNumber2);
            //obj2.Invoke(50, 255.45f, 123.456);


            /******************** Predicate ********************/


            /*
             The Predicate Generic Delegate in C# is used whenever your delegate returns a Boolean value,
             by taking only one input parameter. In our example
             */


            Predicate<string> predicate = new Predicate<string>(CheckLength);

           bool status = predicate.Invoke("vinay");
            Console.WriteLine(status);
           
            //CheckLengthDelegate obj3 = new CheckLengthDelegate(CheckLength);
            //bool Status = obj3.Invoke("Pranaya");
            
           
            Console.ReadKey();
        }
        public static double AddNumber1(int no1, float no2, double no3)
        {
            return no1 + no2 + no3;
        }
        public static void AddNumber2(int no1, float no2, double no3)
        {
            Console.WriteLine(no1 + no2 + no3);
        }
        public static bool CheckLength(string name)
        {
            if (name.Length > 5)
                return true;
            return false;
        }
    }
}
