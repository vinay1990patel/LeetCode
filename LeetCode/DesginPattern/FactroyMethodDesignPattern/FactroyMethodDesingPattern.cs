using LeetCode.DesginPattern.AbstractFactoryDesignPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.DesginPattern.FactroyMethodDesignPattern
{

    /*
     
    * Factory Method Design Pattern *
                               - In This sub class is responsible to create the object.

     
     */
    public interface IVehicle
    {
        void Manufacturer();
    }


    public class TataCar : IVehicle
    {
        public void Manufacturer()
        {
            
        }
    }


    public class TataTruck : IVehicle
    {
        public void Manufacturer()
        {
        }
    }





    public abstract class CarCompany  // Factory class
    {
        public IVehicle produceVehicale(string VehicleType)
        {
            IVehicle vehicle = ManufacturVehicale(VehicleType);
            vehicle.Manufacturer();
            return vehicle;
        }

        public abstract IVehicle ManufacturVehicale(string VehicleType);
    }

    public class TataCompany : CarCompany {

        public override IVehicle ManufacturVehicale(string VehicleType)
        {
           if(VehicleType == "Car")
            {
                return new TataCar();
            }
           else
            {
                return new TataTruck();
            }
        }
    }




    internal class FactroyMethodDesingPatternClient
    {
        public static void Main()
        {
            CarCompany carCompanyTata = new TataCompany();
            IVehicle vehicleCar = carCompanyTata.produceVehicale("Car");

            IVehicle vehicleTata = carCompanyTata.produceVehicale("Truck");
            
          
        }
    }
}
