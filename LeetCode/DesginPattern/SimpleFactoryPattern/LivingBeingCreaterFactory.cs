using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.DesginPattern.SimpleFactoryPattern
{
  public  class  LivingBeingCreaterFactory : AbstractLivingBeingCreater
    {

        public override IlivingBeing CreateObject(string beingType)
        {
            IlivingBeing ilivingBeing = null;
            
            switch (beingType)
            {
                case "Two":
                    ilivingBeing = new Human();
                    break;
                case "Four":
                    ilivingBeing = new Animal();
                    break;
                    default:  throw new ApplicationException("exception in getting in animal") ;
            }

            return ilivingBeing;
        }

    }
}
