using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.CreationalDesignPattern.singleton.Solution
{
    internal class singletonClient
    {

        public static void clientMethod()
        {
            AppSetting appSetting = AppSetting.GetAppSettingInstance();
            AppSetting appSettingCopy = AppSetting.GetAppSettingInstance();

            Console.WriteLine(appSetting == appSettingCopy);
          
        }
    }
}
