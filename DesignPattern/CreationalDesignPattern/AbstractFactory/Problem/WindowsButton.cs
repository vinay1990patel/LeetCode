using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.CreationalDesignPattern.AbstractFactory.Problem
{
    internal class WindowsButton:IButton
    {
        public void RenderButton()
        {
            Console.WriteLine("Render windows button problem");
        }
    }
}
