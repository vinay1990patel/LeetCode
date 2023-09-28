using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace EnitityFrameWork
{
    internal class Lambda
    {
      public  static  Func<int, int, int > Multiply = (x,y) =>x*y;

        public static Func<int, int> multiplybyTen = num =>
        {
           int result = num * 10;
            return result;
             
        };

        public static Func<int, int> NextNumber = (x) => x + 1;
      
    }
}
