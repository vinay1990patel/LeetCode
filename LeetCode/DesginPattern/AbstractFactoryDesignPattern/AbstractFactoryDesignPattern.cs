using LeetCode.DesginPattern.FactoryDesignPattern;
using LeetCode.LeetCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.DesginPattern.AbstractFactoryDesignPattern
{
    /*

    * Abstract Factory Design Pattern*
                                  - If we have categorized classes then we can use abstract factory design pattern.
                                  - It retruns facotry then that factory will instiniate the object.
   
     */

    public interface ICar
    {
        void Manufacture();
    }

   public interface ITruck
    {
        void Manufacture();
    }


    // For Tata
     class TataCar : ICar
    {
        public void Manufacture() { }
    }

   class TataTruck: ITruck
    {
        public void Manufacture()
        {

        }
    }

    // For Mahindra 


    class MahindraCar :ICar
    {
        public void Manufacture()
        {

        }
    }

    class MahindraTruck : ITruck
    {
        public void Manufacture()
        {

        }
    }


    public abstract class VehicleCompany  // Factory Class who ever will inherit it those will be responsible to Instansiate the object
    {
        public abstract ITruck GetTruck();
        public abstract ICar GetCar();

    }
    

    public class TataCompany: VehicleCompany
    {
        public override ICar GetCar()
        {
           return new TataCar();
        }
        public override ITruck GetTruck()
        {
            return new TataTruck();
        }
    }


    public class MahindraComapny :VehicleCompany
    {
        public override ICar GetCar()
        {
          return  new  MahindraCar();
        }

        public override ITruck GetTruck()
        {
            return new MahindraTruck();
        }

    }




    class Client
    {
        public static void Main()
        {
            VehicleCompany tataCompany = new TataCompany();
              ITruck tataTruck = tataCompany.GetTruck();
              ICar tataCar = tataCompany.GetCar();


            VehicleCompany mahindraCompany = new MahindraComapny();
            ITruck mahindraTruck = mahindraCompany.GetTruck();
            ICar mahindraCar = mahindraCompany.GetCar();
           
        }
    }


}
