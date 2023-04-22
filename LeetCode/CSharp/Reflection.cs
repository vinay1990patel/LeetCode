using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
namespace LeetCode.CSharp
{
    internal class Reflection
    {

        public static void reflectionData()
        {
             Type t = Type.GetType("LeetCode.CSharp.Employee");

            MemberInfo[] memberInfo = t.GetMembers();
            foreach (MemberInfo mi in memberInfo)
            {
                Console.WriteLine("Member Info ==>" + mi.Name + "Of Type" + mi.MemberType.ToString());
            }

            PropertyInfo[] propertyInfos =  t.GetProperties();
            foreach (PropertyInfo pi in propertyInfos)
            {
                Console.WriteLine("property Info " + pi.Name + " Type Of" + pi);
            }

            MethodInfo[] methodInfos = t.GetMethods();
                foreach(MethodInfo mi in methodInfos)
            {
                Console.WriteLine("Method Info +" + mi.Name + "Type Of" + mi.ReturnType.Name);
            }
        }



    }


    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string FirstName { get; set; }

        public void add()
        {
            Console.WriteLine("add");
        }
        public void Sub()
        {
            Console.WriteLine("add");
        }
        public void Devide()
        {
            Console.WriteLine("add");
        }
    }
}
