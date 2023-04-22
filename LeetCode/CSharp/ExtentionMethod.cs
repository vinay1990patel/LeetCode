using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CSharp
{
    


    public static class extImplementaion
    {

        public static string firstChar(this string str)
        {

            if(str.Length > 1) { 
            char[] charsArray = str.ToCharArray();
            charsArray[0] = char.IsUpper(charsArray[0]) ? char.ToLower(charsArray[0]) : char.ToUpper(charsArray[0]);
            return new string (charsArray);
            }

            return str;
        }

    }


}
