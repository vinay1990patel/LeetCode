using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.CreationalDesignPattern.singleton.Solution
{
    internal sealed class singletonClient
    {

        public static void clientMethod()
        {
            AppSetting appSetting = AppSetting.GetAppSettingInstance();
            AppSetting appSettingCopy = AppSetting.GetAppSettingInstance();
            appSetting.GetDbUrl();
            Console.WriteLine(appSetting == appSettingCopy);
          
        }
    }
}
