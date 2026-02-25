using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.DesginPattern
{
    internal sealed class DBConnection
    {
        private static DBConnection Instance = null;

        private static readonly object lockObject = new object();
        private DBConnection() { }
        public static DBConnection getDBConnection
        {
            get
            {
                lock (lockObject)
                {

                    if (Instance == null)
                    {
                        Instance = new DBConnection();
                    }

                    return Instance;
                }
            }
        }
    

   
    }


    public class ClientDB
    {
        public void GetData()
        {
          var DBInstance =  DBConnection.getDBConnection;
        }
    }
}

/*
 ex. 1. Db Connecton
     2. Logger
     3. Threadpool
     4. Confihuration Object (Configuraton Object)
 */