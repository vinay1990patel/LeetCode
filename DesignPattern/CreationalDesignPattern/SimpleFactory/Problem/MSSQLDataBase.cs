using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.CreationalDesignPattern.SimpleFactory.Problem
{
    internal class MSSQLDataBase : IDataBaseConnection
    {
        public string ConnectToDataBase()
        {
            Console.WriteLine("Connected to MS Sql Database");
          return "Connected to MS Sql Database";
        }
    }
}
