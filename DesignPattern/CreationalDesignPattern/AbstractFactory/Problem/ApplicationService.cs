using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.CreationalDesignPattern.AbstractFactory.Problem
{
    internal class ApplicationService
    {
        public static void GetUISwitchConfiguration()
        {
            /*
              
             *  If we have categorized classes then we can use abstract factory design pattern.
             *  It returns factory then that factory will instantiate the object.
             *  ApplicationService class is tightly coupled with below classes
              
             
             */
            WindowsButton windowsButton = new WindowsButton();  
            WindowsScrollBar windowsScrollBar = new WindowsScrollBar(); 
            windowsButton.RenderButton();
            windowsScrollBar.ScrollBar();

            MacButton macButton = new MacButton();
            MacScrollBar macScrollBar = new MacScrollBar();
            macButton.RenderButton();
            macScrollBar.ScrollBar();
           


        }
    }
}
