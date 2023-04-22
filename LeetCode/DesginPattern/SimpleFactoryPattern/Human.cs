using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.DesginPattern.SimpleFactoryPattern
{
   public  class Human: IlivingBeing
    {

        public void HaveLegs()
        {
            Console.WriteLine("humans have 2 legs");
        }

        public void EatingHabit()
        {
            Console.WriteLine("humans eats wheats");
        }
    }
}
