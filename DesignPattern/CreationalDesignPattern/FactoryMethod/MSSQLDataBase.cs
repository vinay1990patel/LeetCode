using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.CreationalDesignPattern.FactoryMethod
{
    internal class MSSQLDataBase : IDataBaseConnection
    {
        public string ConnectToDataBase()
        {
            Console.WriteLine("Connected to MS Sql Database solution");
          return "Connected to MS Sql Database";
        }
    }
}
