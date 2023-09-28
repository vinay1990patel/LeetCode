using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CSharp
{
     interface ExplicitInterface
    {

       public void print();


    }

   interface ExplicitInterface1
    {
      public  void print();
    }

    interface ExplicitInterface2
    {
        public void prin1();
    }

    class Cunsumer : ExplicitInterface, ExplicitInterface1, ExplicitInterface2
    {
        void ExplicitInterface.print()
        {
            throw new NotImplementedException();
        }

        void ExplicitInterface1.print()
        {
            throw new NotImplementedException();
        }


        public void callAllInterface()
        {

            Cunsumer C1 = new Cunsumer();

            ((ExplicitInterface)C1).print();
            ((ExplicitInterface1)C1).print();
        }

        public void prin1()
        {
            throw new NotImplementedException();
        }
    }
}
