using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.CreationalDesignPattern.AbstractFactory.Solution
{
    internal class MacButton : IButton
    {
        public void RenderButton()
        {
            Console.WriteLine($"Render Mac button Solution.");
        }
    }
}
