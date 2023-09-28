using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CSharp
{


    // Abstract class are used to expose common functionalaltiy to out side cunsumer.
    /*
     In below example bank one and back two are using same funcionality so in below case we can use abstract class
    
     */

    /* 
     Now if bank two wants Inssurance funinonality then we need to use interface
     */


    internal abstract class  AbstractSample
    {
        public AbstractSample() { }


        public abstract void Credit();
        public abstract void Debit();
        public abstract void Saving();




    }


    interface IInsurance
    {

        public void CalculateIInsurance();
      //  public void CalculateTotalSum();


    }

    class Bank1 : AbstractSample
    {
        public override void Credit()
        {
            throw new NotImplementedException();
        }
        public override void Debit()
        {
            throw new NotImplementedException();
        }

        public override void Saving()
        {
            throw new NotImplementedException();
        }
    }

    class Bank2 : AbstractSample, IInsurance
    {
        public void CalculateIInsurance()
        {
            throw new NotImplementedException();
        }

        public override void Credit()
        {
            throw new NotImplementedException();
        }

        public override void Debit()
        {
            throw new NotImplementedException();
        }

        public override void Saving()
        {
            throw new NotImplementedException();
        }

    }




}
