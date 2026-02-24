using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.CreationalDesignPattern.AbstractFactory.Solution
{
    internal class ApplicationServiceSolution
    {
        private IButton button;
        private IScrollBar scrollBar;

        public ApplicationServiceSolution(IUIFactory factory)
        {
            this.button = factory.CreateButton();
            this.scrollBar = factory.CreateScrollBar();
        }

        public void RenderUI()
        {
            button.RenderButton();
            scrollBar.ScrollBar();
        }
        public static void GetUISwitchConfiguration()
        {
            /*
              
             *  If we have categorized classes then we can use abstract factory design pattern.
             *  It returns factory then that factory will instantiate the object.
             *  ApplicationService class is tightly coupled with below classes
              
             
             */

            // Use Windows UI

            IUIFactory Windowsfactory = new WindowsFactory();
            ApplicationServiceSolution applicationServiceSolution = new ApplicationServiceSolution(Windowsfactory);
            applicationServiceSolution.RenderUI();
            


        }
    }
}
