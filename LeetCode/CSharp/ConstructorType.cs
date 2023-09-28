using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CSharp
{
    public class ConstructorType
    {
        // 1. Default Constructor         ==> A Constructor without any  parameter
        // 2. Parameterized Constructor   ==> A Constructor with atleast one parameter
        // 3. Copy Constructor            ==> A Constructor which create the object by coping the variable from other object is called copy constructor
        // 4. Static Constructor          ==> can be use for inisilize static member no accesfire allowed.
        // 5. Private Costructor          ==> object creation and inheritance is not possible if class have private constructor it is used for singlton dedign pattern.


        // ==> private constructor is used when class have only static memebr into it. 


        public static int p = 10;
       public ConstructorType() {
            Console.WriteLine("A");
        }
       static ConstructorType() {
            Console.WriteLine("Static A");
        }

        public void Method1()
        {
            Console.WriteLine("Method1");
        }
    
    }

    public class B : ConstructorType
    {
        public B()
        {
            Console.WriteLine("B");
        }
        static B()
        {
            Console.WriteLine("Static B");
        }
        public void Method1()
        {
            Console.WriteLine("Method2");
        }
    }







}
