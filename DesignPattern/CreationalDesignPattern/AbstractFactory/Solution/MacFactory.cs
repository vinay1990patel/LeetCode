using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.CreationalDesignPattern.AbstractFactory.Solution
{
    internal class MacFactory : IUIFactory
    {
        public IButton CreateButton()
        {
            return new MacButton();
        }

        public IScrollBar CreateScrollBar()
        {
           return new MacScrollBar();
        }
    }
}
