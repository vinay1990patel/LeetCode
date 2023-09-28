using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CSharp
{
    internal class ObjectCamparision
    {

        public static void Compare()
        {
            c1 c11 = new c1();
            c11.FistName = "vinay";
            c11.lastName = "patel";
            c11.age = 1;

            c2 c222 = new c2();

            c222.FistName = "vinay";
            c222.lastName = "patel";
            c222.age = 1;

          bool r =  c11.Equals(c222);

            

        }


        

       
    }



    public class c1
    {
        public string FistName { get; set; }
        public string lastName { get; set; }
        public int age { get; set; }
    }


    public class c2
    {
        public string FistName { get; set; }
        public string lastName { get; set; }
        public int age { get; set; }
    }
}
