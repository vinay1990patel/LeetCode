using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.CreationalDesignPattern.singleton.Solution
{
    internal class AppSetting
    {
        private string dataBaseUrl;
        private string apiKey;

        private static AppSetting instance;
        public static readonly Object lockObject = new Object();

        private AppSetting()
        {
            // we can read settings from config file
            dataBaseUrl = "https:\\SqlDataBase\\AzureInstance";
            apiKey = "dssa23we%%$2edd#";
        }


        public static AppSetting GetAppSettingInstance()
        {
            lock (lockObject)
            {
                if (instance == null)
                {
                    instance = new AppSetting();
                }
                return instance;
            }
        }
        public string GetDbUrl()
        {
            return dataBaseUrl;
        }
        public string GetApiKey()
        {
            return apiKey;
        }

    }
}
