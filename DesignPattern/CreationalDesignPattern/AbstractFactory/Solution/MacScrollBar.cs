using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.CreationalDesignPattern.AbstractFactory.Solution
{
    internal class MacScrollBar:IScrollBar
    {
        public void ScrollBar()
        {
            Console.WriteLine("Scrolling Mac Scroll Bar Solution");
        }
    }
}
