using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.CreationalDesignPattern.BuilderDesign.Problem.Problem_1
{
    internal class House
    {
        string name;
        bool haseGraden;
        bool hasSwimingPool;
        string roof;
        string buildMaterialName;
        public House(string name , bool hasGarden, bool hasSwimmingPool, string roof, string buildMaterialName) { 
            this.name = name;
            haseGraden = hasGarden;
            hasSwimingPool = hasSwimmingPool;
            this.roof = roof;
            this.buildMaterialName = buildMaterialName;
        }

        public override string ToString() {
            return $"House have some these Details {name},{hasSwimingPool},{haseGraden},{roof},{buildMaterialName}";
        }
    }
}
