using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.DesginPattern.SimpleFactoryPattern
{
   public  class Animal: IlivingBeing
    {
       

       public void HaveLegs()
        {
            Console.WriteLine("animals have four legs");
        }

      public  void EatingHabit()
        {
            Console.WriteLine("animans eats Grass");
        }
    }
}
