using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.CreationalDesignPattern.FactoryMethod
{
  public interface IDataBaseConnection
    {
        public string ConnectToDataBase();
    }
}
