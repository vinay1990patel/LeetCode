using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.CreationalDesignPattern.AbstractFactory.Solution
{
    internal interface IUIFactory
    {
        IButton CreateButton();
        IScrollBar CreateScrollBar();
    }
}
