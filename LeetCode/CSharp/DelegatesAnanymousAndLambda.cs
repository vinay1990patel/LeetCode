using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace LeetCode.CSharp
{

    delegate void ShowNameDelegate(string name);
    internal class DelegatesAnanymousAndLambda
    {

        public static void ShowName(string name)
        {
            Console.WriteLine("Your Name is :" + name);
        }


       ShowNameDelegate nameDelegate = new ShowNameDelegate(ShowName); // using Delegate


      ShowNameDelegate showNameDelegate = delegate (string name)  // Ananymous Function   // The anonymous methods are created using the delegate keyword and when we invoke the delegate, the anonymous method is going to be executed.
      {
            Console.WriteLine("Your name is by Ananymous Method :" + name);
        };

        Action<string> showNameByLambda = (name) =>          // Lambda
        {
            Console.WriteLine("Your name by Lambda :" + name);
        };



    }
}
