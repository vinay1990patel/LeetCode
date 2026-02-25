using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.CreationalDesignPattern.SimpleFactory.Solution
{
    internal class MySQLDataBase : IDataBaseConnection
    {
        public string ConnectToDataBase()
        {
            Console.WriteLine("connected to My SQL Database solution");
            return "connected to My SQL Data Base";
        }
    }
}
