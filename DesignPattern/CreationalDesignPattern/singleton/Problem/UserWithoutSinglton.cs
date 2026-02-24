using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.CreationalDesignPattern.singleton.Problem
{
    internal class UserWithoutsingleton
    {
        public static void Main()
        {
            AppSetting appSetting = new AppSetting();
            AppSetting appSettingCopy = new AppSetting();

            Console.WriteLine(appSetting.GetApiKey); // these will create two object in worst case the count will be much more.
            Console.WriteLine(appSetting.GetApiKey);
            Console.WriteLine(appSetting == appSettingCopy); // will return true if both object are same or only one object is created
        }
    }
}
