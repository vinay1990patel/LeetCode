using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LeetCode
{
    internal class HasSetDemo
    {





        

        public static void findDulticateInArray(int[] input)
        {

            HashSet<int> set = new HashSet<int>();

            var result = input.Where(x => set.Add(x));

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }

            var isDuplicate = input
                               .Any(x => !set.Add(x));

            Console.WriteLine(isDuplicate);

            var dupliCateValue = input.Where(x => !set.Add(x));

            Console.WriteLine(dupliCateValue.Count()); 
               
             
             foreach(var item in dupliCateValue) {
                Console.WriteLine("Duplicate Iteam =>" +item);
            }
            

        }
       
       
    }
}
