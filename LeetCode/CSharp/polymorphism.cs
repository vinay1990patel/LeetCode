using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;

namespace LeetCode.CSharp
{
    internal class PolymorphismBaseClass
    {
        public virtual void method1()
        {
            Console.WriteLine( "base Method1");
        }

        public virtual void method2()
        {
            Console.WriteLine("Base Class method2");
        }
    }


    class PolymorphismDerivedClass : PolymorphismBaseClass
    {
        public  new  void method2()
        {
            Console.WriteLine("Hidden Method2 Class");
        }

        public override void method1()
        {
            Console.WriteLine("Over Ridden Method");
        }
    }



    class mainClass { 

    public static void Main()
    {
            PolymorphismBaseClass polymorphismBaseClass = new PolymorphismBaseClass();
            polymorphismBaseClass.method1();

            PolymorphismDerivedClass polymorphismDerivedClass = new PolymorphismDerivedClass();
            polymorphismDerivedClass.method1();
            polymorphismDerivedClass.method2 ();


            PolymorphismBaseClass polymorphismBaseClass1 = new PolymorphismDerivedClass ();
            polymorphismBaseClass1.method1 ();


       
    }

    }



    class OverLoadingClass
    {
        public int Method(int x, int y)
        {
            return 1;
        }

        public int Method(int y, int x, bool z)
        {
            return 1;
        }

       

    }


    class PverLoadingChildClass : OverLoadingClass
    {
        public int Method(int y, int x, bool z, int k)
        {
            return 1;
        }
    }



}
