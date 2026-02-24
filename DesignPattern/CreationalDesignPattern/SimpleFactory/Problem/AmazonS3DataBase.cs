using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.CreationalDesignPattern.SimpleFactory.Problem
{
    internal class AmazonS3DataBase : IDataBaseConnection
    {
        public string ConnectToDataBase()
        {
            Console.WriteLine("Connected to Amazon S3 Database");
            return "Connected to Amazon S3 Database";
        }
    }
}
