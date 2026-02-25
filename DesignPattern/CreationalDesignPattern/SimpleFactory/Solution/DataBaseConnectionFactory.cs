using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.CreationalDesignPattern.SimpleFactory.Solution
{
    internal class DataBaseConnectionFactory
    {
        public static IDataBaseConnection CreateDataBaseConnectionFactory(string datbaseType)
        {
            switch (datbaseType.ToLower())
            {
                case "mssql":
                    return new MSSQLDataBase();
                case "mysql":
                    return new MySQLDataBase();
                case "s3":
                    return new AmazonS3DataBase();
                case "azure":
                    return new SQLAzureDataBase();

                default:
                    return new MSSQLDataBase();


            }


        }
    }
}
