using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.SOLID
{
    internal class LiskovSubstituion
    {
        /* the object of a derived class should be able to replace an object of the base class without bringing any errors in the system or modifying the behavior of the base class. 
         * That means child class objects should be able to replace parent class objects without compromising application integrity. */

        public virtual void StartEngine()
        {

        }
    
    }


    class car : LiskovSubstituion
    {
        public override void StartEngine()
        {

        }
    }

    class ByCicle : LiskovSubstituion
    {
        /* byCycle dont have engine so it can start hence child class object is not subtituble with parent class object */
       
       
        public override void StartEngine()
        {

        }
    }



    public class VehicleWithEngine
    {
        public virtual void StartEngine()
        {

        }
    }

    public class VehicleWithoudEngine
    {
        public virtual void StartEngine()
        {

        }
    }


    class car1 : VehicleWithEngine
    {
        public override void StartEngine()
        {

        }
    }

    class ByCycle : VehicleWithoudEngine
    {
        public override void StartEngine()
        {
            base.StartEngine();
        }
    }

}
