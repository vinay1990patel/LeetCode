using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.CreationalDesignPattern.SimpleFactory.Solution
{
    internal class SQLAzureDataBase : IDataBaseConnection
    {
        public string ConnectToDataBase()
        {
            Console.WriteLine("Connected to SQL Azure Database solution");
            return "Connected to SQL Azure Database";
        }
    }
}
