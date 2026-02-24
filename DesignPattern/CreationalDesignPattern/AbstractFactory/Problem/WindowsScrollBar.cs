using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.CreationalDesignPattern.AbstractFactory.Problem
{
    internal class WindowsScrollBar:IScrollBar
    {
        public void ScrollBar()
        {
            Console.WriteLine($"Scrolling windows scroll bar problem");
        }
    }
}
