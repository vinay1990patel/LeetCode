using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.SOLID
{
    public class OpenClosePrinciple
    {
        /* software entities such as modules, classes, functions, etc.
         * should be open for extension, but closed for modification. */

        public int Calculator(int a, int b, string OprtaionType)
        {

           switch (OprtaionType)
            {
                case "+":
                    { 
                    return a + b;
                    }
                    case "-":
                    {
                      return  a - b;
                    }
            }
            return 0;
        }

        // now if we want to add new functionality for divide.
        // insteat of modifying current class add abstract class or interface and impliment as below.
    }


    interface IOpenClosePrinciple
    {
        int calculator(int a, int b);
    }

    public class addClass : IOpenClosePrinciple
    {
        public int calculator(int a, int b)
        {
            return a + b;
        }
    }

    // now if we want to add new method for division.
    // since we are not allowed for modification so will add new class and impliment calculator interface  


    public class DivideClass : OpenClosePrinciple, IOpenClosePrinciple
    {
        public int calculator(int a, int b)
        {
            return a / b;
        }
    }
}
