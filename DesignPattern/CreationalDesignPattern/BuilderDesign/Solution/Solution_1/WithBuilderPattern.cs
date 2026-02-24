using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.CreationalDesignPattern.BuilderDesign.Solution.Soultion_1
{
    internal class WithBuilderPatternSolution
    {
        public static void WithBuilderPattern()
        {

            House house = new House.HouseBuilder(name: "vinay", buildMaterialName: "Prime material")
                                  .SetHasGarden(true)
                                  .SetHasSwimmingPool(true)
                                  .SetRoof("tiles")
                                  .Build();

            Console.WriteLine($"{house} from solution");
        }
    }
}
