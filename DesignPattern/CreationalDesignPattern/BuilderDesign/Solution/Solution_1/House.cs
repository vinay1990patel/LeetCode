using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.CreationalDesignPattern.BuilderDesign.Solution.Soultion_1
{
    public class House
    {
        public string Name { get; }
        public bool HasGarden { get; }
        public bool HasSwimmingPool { get; }
        public string Roof { get; }
        public string BuildMaterialName { get; }

        // Private constructor - only the builder can create a House
        private House(HouseBuilder builder)
        {
            // nested types can access each other's private members, so these are available
            Name = builder.name;
            HasGarden = builder.hasGarden;
            HasSwimmingPool = builder.hasSwimmingPool;
            Roof = builder.roof;
            BuildMaterialName = builder.buildMaterialName;
        }

        public override string ToString()
        {
            return $"House '{Name}': Material={BuildMaterialName}, Roof={Roof ?? "N/A"}, Garden={HasGarden}, SwimmingPool={HasSwimmingPool}";
        }

        public class HouseBuilder
        {
            // Required fields (kept as fields for simple access from outer class)
            internal readonly string name;
            internal readonly string buildMaterialName;

            // Optional fields with defaults
            internal bool hasGarden;
            internal bool hasSwimmingPool;
            internal string? roof;

            /// <summary>
            /// Required Parameters
            /// </summary>
            /// <param name="name">Name of the house</param>
            /// <param name="buildMaterialName">Primary build material</param>
            public HouseBuilder(string name, string buildMaterialName)
            {
                if (string.IsNullOrWhiteSpace(name)) throw new ArgumentException("name is required", nameof(name));
                if (string.IsNullOrWhiteSpace(buildMaterialName)) throw new ArgumentException("buildMaterialName is required", nameof(buildMaterialName));

                this.name = name;
                this.buildMaterialName = buildMaterialName;
            }

            public HouseBuilder SetHasGarden(bool hasGarden)
            {
                this.hasGarden = hasGarden;
                return this;
            }

            public HouseBuilder SetHasSwimmingPool(bool hasSwimmingPool)
            {
                this.hasSwimmingPool = hasSwimmingPool;
                return this;
            }

            public HouseBuilder SetRoof(string roof)
            {
                this.roof = roof;
                return this;
            }

            public House Build()
            {
                return new House(this);
            }
        }
    }

   
}
