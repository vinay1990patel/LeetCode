using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.DesginPattern.FactoryDesignPattern
{

    /* 

* Factory Design Pattern *   
                       -  Factory Design Patern use to create the object of a perticular type by using Factory class.
                       -  In factory design pattern factory class direct gives the object of class which is requested.
                       -  Factory class will return object directly

    */

    public interface ICar
    {
        void StartCar();
    }

    class FourSeaterCar : ICar
    {
        public void StartCar() { 
        }
    }

    class SixSeaterCar : ICar
    {
        public void StartCar()
        {

        }
    }


   public class CarFactory
    {
      public  ICar GetCar(string CarType)
        {
            switch (CarType)
            {
                case "FourSeater":
                    return new FourSeaterCar();
                case "SixSeater":
                    return new SixSeaterCar();
            }
            return null;
        }
    }


    class Client
    {
        public static void Main(string[] args) { 
         
            CarFactory carFactory = new CarFactory();
            ICar SixSeater = carFactory.GetCar("SixSeater");
            ICar FourSeater = carFactory.GetCar("FourSeater");
        }
    }
}
