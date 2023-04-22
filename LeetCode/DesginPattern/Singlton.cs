using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.DesginPattern
{
    internal class Singlton
    {
        private static Singlton Instance = null;

        private static readonly object lockObject = new object();
        private Singlton() { }
        public static Singlton getInstance
        {
            get
            {
                lock (lockObject)
                {

                    if (Instance == null)
                    {
                        Instance = new Singlton();
                    }

                    return Instance;
                }
            }
        }
    }
}
