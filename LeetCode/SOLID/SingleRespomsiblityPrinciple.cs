using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.SOLID
{
    internal class SingleRespomsiblityPrinciple
    {
        /*  Each software module or class should have only one reason to change.
         *  In other words, we can say that each module or class should have only one responsibility to do. */

        public void SendMail()
        {

            //  should have only one responsibilty to do. or only reason to changes
        }


       public void Print()
        {
            // print should be in other class
        }
    }
}
