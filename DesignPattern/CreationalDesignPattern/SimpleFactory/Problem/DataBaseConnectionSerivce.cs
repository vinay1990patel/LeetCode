using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.CreationalDesignPattern.SimpleFactory.Problem
{
    internal class DataBaseConnectionSerivceProblem
    {
      
        public static void GetDataBaseConnectionClientProblem()
        {
            IDataBaseConnection MySQLDataBaseConnection = new MySQLDataBase();
            MySQLDataBaseConnection.ConnectToDataBase();
            IDataBaseConnection SQLAzureDataBaseConnection = new SQLAzureDataBase();
            SQLAzureDataBaseConnection.ConnectToDataBase();

        }

        /*
             * Factory Design pattern give the requested object of a class on demand or when required.
             * if in future we want to support for MS Sql database we new to create object manually.
             * And need to modify the DataBaseConnectionSerivce class each and every time.
             * also it breaks the open/close principle. 
             * DataBaseConnectionService is tightly coupled with concreate classes(MySQLDataBase, SQLAzureDataBase)
             
        */


    }
}
