using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.CreationalDesignPattern.SimpleFactory.Solution
{
    internal class DataBaseConnectionSerivceSolution
    {
      
        public static void GetDataBaseConnectionClientSolution()
        {
            string dataBaseType = string.Empty;
            IDataBaseConnection dataBaseConnection = DataBaseConnectionFactory.CreateDataBaseConnectionFactory(dataBaseType = "s3");
            dataBaseConnection.ConnectToDataBase();
        }




    }
}
