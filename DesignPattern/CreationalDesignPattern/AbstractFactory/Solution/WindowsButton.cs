using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.CreationalDesignPattern.AbstractFactory.Solution
{
    internal class WindowsButton:IButton
    {
        public void RenderButton()
        {
            Console.WriteLine("Render windows button Solution");
        }
    }
}
