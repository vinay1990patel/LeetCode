using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.CreationalDesignPattern.FactoryMethod
{
    internal class OnCloudDataBaseConnectionFactory
    {
        public static IDataBaseConnection CreateDataBaseConnectionFactory(string datbaseType)
        {
            switch (datbaseType.ToLower())
            {
                case "s3":
                    return new AmazonS3DataBase();
                case "azure":
                    return new SQLAzureDataBase();
                default:
                    return new SQLAzureDataBase();


            }


        }
    }
}
