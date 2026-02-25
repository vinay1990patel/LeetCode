using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.CreationalDesignPattern.singleton.Problem
{
    internal class AppSetting
    {
        private string dataBaseUrl;
        private string apiKey;

       
        public AppSetting()
        {
            // we can read settings from config file
            dataBaseUrl = "https:\\SqlDataBase\\AzureInstance";
            apiKey = "dssa23we%%$2edd#";
        }

        public string GetDbUrl()
        {
            return dataBaseUrl;
        }
        public string GetApiKey() { 
            return apiKey;
        }

    }
}
