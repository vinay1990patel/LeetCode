using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.SOLID
{
    internal class DependencyInversionPrinciple
    {

        /* 1. high-level modules/classes should not depend on low-level modules/classes. Both should depend upon abstractions, 
         * 2. abstractions should not depend upon details. Details should depend upon abstractions. */
        private Desktop desktop;
        private QwertyKeyPad QwertyKeyPad;

        public DependencyInversionPrinciple()
        {
            this.desktop = new Desktop();
            this.QwertyKeyPad = new QwertyKeyPad();  // both are tightly coupled in every initilaization of DependencyInversionPrinciple Desktop and QwertyKeyPad will be call or bind
        }


        /* To Avoid above tight coupling le the user pass in parameterised constructor */


        public DependencyInversionPrinciple (Desktop desktop, QwertyKeyPad qwertyKeyPad)
        {
            this.desktop = desktop;
            this.QwertyKeyPad = qwertyKeyPad;
        }
    
    }


    class Desktop
    {

    }
    class QwertyKeyPad
    {

    }
}
