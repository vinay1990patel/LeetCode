using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.CreationalDesignPattern.SimpleFactory.Problem
{
    internal class MySQLDataBase : IDataBaseConnection
    {
        public string ConnectToDataBase()
        {
            Console.WriteLine("Connected to mysql database");
            return "connected to my sql database";
        }
    }
}
