using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.SOLID
{
    internal class DependencyInversionPrinciple
    {

        /* 1. high-level modules/classes should not depend on low-level modules/classes. Both should depend upon abstractions, 
         * 2. abstractions should not depend upon details. Details should depend upon abstractions. */
        private Desktop desktop;
        private QwertyKeyPad QwertyKeyPad;

        public DependencyInversionPrinciple()    
        {
            this.desktop = new Desktop();   //DependencyInversionPrinciple class depenednt on lower level class 
            this.QwertyKeyPad = new QwertyKeyPad();  // both are tightly coupled in every initilaization of DependencyInversionPrinciple Desktop and QwertyKeyPad will be call or bind
        }


        /* To Avoid above tight coupling le the user pass in parameterised constructor */


        public DependencyInversionPrinciple (Desktop desktop, QwertyKeyPad qwertyKeyPad)
        {
            this.desktop = desktop;
            this.QwertyKeyPad = qwertyKeyPad;
        }
    
    }


    class Desktop
    {

    }
    class QwertyKeyPad
    {

    }


   // Example 2 


    public class DataAccessLayer
    {
        IFlieLogger _logger;
        public DataAccessLayer( IFlieLogger flieLogger)  //5.  it will be loosly cuopled now
        {
            _logger = flieLogger;
        }


        public void AddCustomer()       
        {
          FileLoggerClass fileLoggerClass = new FileLoggerClass();   //1. Here Data AccessLayer (high level class is depened on low level class (FileLogerclass))
                                                                     //2. to resolve this create inteface and put logMethod inside it.
            fileLoggerClass.log();


            _logger.log();        // use like this 

        }
    }


   public interface IFlieLogger   // 3.
    {
        void log();
    }
    class FileLoggerClass : IFlieLogger // 4.
    {
        public void log()
        {
            Console.WriteLine("loging");
        }
    }


}
