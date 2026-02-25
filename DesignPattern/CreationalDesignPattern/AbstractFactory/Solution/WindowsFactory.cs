using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.CreationalDesignPattern.AbstractFactory.Solution
{
    internal class WindowsFactory : IUIFactory
    {
        public IButton CreateButton()
        {
            return new WindowsButton();
        }

        public IScrollBar CreateScrollBar()
        {
           return new WindowsScrollBar();
        }
    }
}
