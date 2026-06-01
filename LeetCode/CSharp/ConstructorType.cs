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
        // 5. Private Constructor          ==> object creation and inheritance is not possible if class have private constructor it is used for singleton design pattern.


        // ==> private constructor is used when class have only static member into it. 


        public static int p = 10;
        string name {  get; set; }
        string lastName {  get; set; }
       public ConstructorType() {
            Console.WriteLine("A");
        }
       static ConstructorType() {
            Console.WriteLine("Static A");
        }

       
        public ConstructorType(string name , string lastName)
        {
            name = name;
            lastName = lastName;
        }


        // Copy Constructor takes the instace of it class object as input parameter.copy constructor which creates the new object by copyinh value from exsting object as input parameter
        public ConstructorType(ConstructorType constructorType)
        {
            name = constructorType.name;
            lastName = constructorType.lastName;
        }


        ~ConstructorType()  // Finalizers
        {
            //Finalizers cannot be defined in structs.They are only used with classes.
            //A class can only have one finalizer.
            //Finalizers cannot be inherited or overloaded.
            //Finalizers cannot be called. They are invoked automatically.
            //A finalizer does not take modifiers or have parameters.

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
