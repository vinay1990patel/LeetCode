using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;

namespace LeetCode.CSharp
{

    // if end user dont want that his class should not be used as base class for other child class then we can use shealed class.

    // but still we can access the member of base class by creating object of base class.
    // To protect from above condition we can create private constructor of base class.

    public sealed class BaseClass
    {

        private BaseClass()
        {
        }
        public void M1()
        {

        }

       
    }

    public class baseClass1
    {
        public  virtual void Method1()
        {
            Console.WriteLine("Class1 Method1");
        }
        public virtual void Method2()
        {
            Console.WriteLine("Class1 Method2");
        }
    }

   public  class SealedClassAndMethods : baseClass1
    {
       // BaseClass B = new BaseClass();
       
       public sealed override void Method1()
        {
            Console.WriteLine("");
        }

        public override void Method2()
        {
            Console.WriteLine("");
        }
        
    }

    public class BaseClass2 : SealedClassAndMethods
    {
        public override void Method2()
        {
            Console.WriteLine("");
        }
    }
}
