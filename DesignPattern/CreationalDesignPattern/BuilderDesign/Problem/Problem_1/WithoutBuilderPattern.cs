using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.CreationalDesignPattern.BuilderDesign.Problem.Problem_1
{
    internal class WithoutBuilderPatternProblem
    {
        public static void BuilderServiceClient()
        {
            /*
             * now problem with this constructor is not much convenient because if we need only few parameter among all
               then we need to create another constructor which will lead below problem.
             -> Constructor Explosion = too many constructor
             -> because to many parameter its difficult to manage 
             
             */
            House house = new House(name:"Patel",hasGarden:true,hasSwimmingPool:true,roof:"Top",buildMaterialName:"extraStrong");
            Console.WriteLine($"{house} with problem");
        }
    }
}
