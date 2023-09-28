using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CSharp
{
    


    public class NewClass
    {
        public void Test()
        {
            Console.WriteLine("Test One");

        }
    }

   

    public static class extImplementaion
    {
       
        public static void main()
        {
            string s = "vinay patel";
            s.firstChar();


            // 

             NewClass newClass = new NewClass();
             newClass.Test();
             newClass.extMethod(5);
        }
        
        
        // This keyword is used for bind the method "firstChar" this string class
        public static string firstChar(this string str)
        {

            if(str.Length > 1) { 
            char[] charsArray = str.ToCharArray();
            charsArray[0] = char.IsUpper(charsArray[0]) ? char.ToLower(charsArray[0]) : char.ToUpper(charsArray[0]);
            return new string (charsArray);
            }

            return str;
        }


        public static void extMethod(this NewClass newClass, int x)
        {
            Console.WriteLine("extented method with new parameter" +x);
        }

    }


}
