using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.CreationalDesignPattern.FactoryMethod
{
    internal class DataBaseConnectionSerivceFactoryMethodSolution
    {
      
        public static void GetDataBaseConnectionClientSolution()
        {
            string dataBaseType = string.Empty;
            IDataBaseConnection OnPremisesdataBaseConnection = OnPremisesDataBaseConnectionFactory.CreateDataBaseConnectionFactory(dataBaseType = "msql");
            OnPremisesdataBaseConnection.ConnectToDataBase();

            IDataBaseConnection cloudDatabaseConnection = OnCloudDataBaseConnectionFactory.CreateDataBaseConnectionFactory(dataBaseType = "s3");
            cloudDatabaseConnection.ConnectToDataBase();
        }




    }
}
