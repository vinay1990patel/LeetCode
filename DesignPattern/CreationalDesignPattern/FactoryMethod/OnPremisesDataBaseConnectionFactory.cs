using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.CreationalDesignPattern.FactoryMethod
{
    internal class OnPremisesDataBaseConnectionFactory
    {
        public static IDataBaseConnection CreateDataBaseConnectionFactory(string datbaseType)
        {
            switch (datbaseType.ToLower())
            {
                case "mssql":
                    return new MSSQLDataBase();
                case "mysql":
                    return new MySQLDataBase();
                default:
                    return new MSSQLDataBase();


            }


        }
    }
}
