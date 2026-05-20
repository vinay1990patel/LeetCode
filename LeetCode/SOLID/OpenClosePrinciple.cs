using LeetCode.CSharp;
using LeetCode.SOLID;
using Microsoft.IdentityModel.Protocols;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.SOLID
{
    public class OpenClosePrinciple
    {
        /* software entities such as modules, classes, functions, etc.
           should be open for extension, but closed for modification. */

        public int GenrateReport( string ReportType)
        {

            switch (ReportType)
            {
                case "CSV":
                    {
                      //  create CSV report Logic;
                      break;
                    }
                case "Excel":
                    {
                        // create excel report logic
                        break;
                    }
            }
            return 0;
        }

        /*
         
           now if we want to add new functionality to create or support text report.
           instead of modifying current class add abstract class or interface and implement as below.
        
         */
        
    }


    public interface IOpenClosePrinciple
    {
        int AddTXTReoport(int a, int b);
    }
  
    

    // now if we want to add new method for division.
    // since we are not allowed for modification so will add new class and implement calculator interface  


    public class SupportTxtClass : OpenClosePrinciple, IOpenClosePrinciple
    {
        public int AddTXTReoport(int a, int b)
        {
            throw new NotImplementedException();
        }
    }


    /*  Example:: 2

       now if we want to add another method to this interface we need to implement that method in the class becaus of that consumer of this interface will be distributed.
       to avoid that we can extend this interface and use it.
     */

    public interface IXmla
    {

        string Execute(int a, int b);
    }

    public class AddClass : IXmla
    {
        public string Execute(int a, int b)
        {
            return "a+b";

        }
    }

    public static class ExecuteTest
    {
        public static string ExecuteExtended(this IXmla xmla, int a, int b)
        {
            return (a + b).ToString();
        }
    }

    public class consumer
    { 
        private readonly IXmla _xmla;
        public consumer(IXmla xmla) {
            _xmla = xmla;
        }

        public void consumerM(int a, int b) { 
            _xmla.Execute(a, b);
            _xmla.ExecuteExtended(a, b);
        }
        
    }
}

