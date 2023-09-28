using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CSharp
{
    internal class EqualsOps
    {
        public static void EqualityOpaerator()
        {
            EmployeeData employeeData = new EmployeeData(); 
            employeeData.FistName = "vinay";
            employeeData.lastName = "patel";

            EmployeeData employeeData11 = employeeData; // for reference type if it is poiting to same object the value will same then result will also same.



            EmployeeData employeeData2 = new EmployeeData();

            employeeData2.FistName = "vinay";
            employeeData2.lastName = "patel";



            int a = 10;    // == and .Equals behave same for value type
            int b =10;



            Console.WriteLine(employeeData == employeeData2);
            Console.WriteLine(employeeData.Equals(employeeData2));
            Console.WriteLine( object.Equals(employeeData,employeeData2));

        }

       

    }


    class EmployeeData
    {
        public string FistName { get; set; }
        public string lastName { get; set; }
    }
}
