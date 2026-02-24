using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.CreationalDesignPattern.AbstractFactory.Problem
{
    internal class MacButton : IButton
    {
        public void RenderButton()
        {
            Console.WriteLine($"Render Mac button problem.");
        }
    }
}
