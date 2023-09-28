using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnitityFrameWork
{
    internal class LINQ
    {






        public static List<string> animalNames = new List<string> { "fawn", "gibbon", "heron", "ibex", "jackalope" };
        public static IEnumerable<string> animalResult = from animalResult in animalNames
                                                         where animalResult.Length >= 5
                                                         orderby animalResult.Length
                                                         select animalResult;


        


        public static void LinqUsingLambda()
        {

            var r = animalNames.Distinct().Where(x => x.Length > 0);

            IEnumerable<string> animalResult1 = animalNames.Where(x => x.Length >= 5).OrderBy(x => x.Length).Select(x => x);

            foreach (var result in animalResult1)
            {
                Console.WriteLine(result);
            }

            Console.WriteLine("**************** Contain ****************");

            IEnumerable<string> animalResult2 = animalNames.Where(x => x.Contains("gib")).OrderBy(x => x).Select(x => x);

            foreach (var r0 in animalResult2)
            {
                Console.WriteLine(r0);
            }


        IEnumerable<string> stringsAnimal =    from value in animalResult1
                                               where value.Contains("gib")
                                               select value;


            foreach (var r1 in stringsAnimal)
            {
                Console.WriteLine(r1);
            }
        }


       

        public static void NthSalary()
        {
            List<int> ints= new List<int>() { 1,2,3,4,5,6,7};

            var result = ints.OrderByDescending(x =>x).Skip(2).Take(1).ToList();
            Console.WriteLine(result[0]);
        }

        public static void LinqForStringIndex() {
            int[] numbers = { 3, 4, 5, 6, 8, 1, 2, 3, 7 };
            string[] strings = { "one", "two", "three", "four", "five", "six", "seven" };
            var result = from n in numbers
                         select strings[n];
            foreach (var item in numbers)
            {
                Console.WriteLine(result);
            }
        
           }

        public static void NumberIndex()
        {
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            var numsInPlace = numbers.Select((num, index) => (Num: num, InPlace: (index))).OrderBy(x =>x);

            Console.WriteLine("Number: In-place?");
            foreach (var n in numsInPlace)
            {
                Console.WriteLine($"{n.Num}: {n.InPlace}");
            }
        }

        public static void SelectMultiPleInputSequance()
        {
            int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            int[] numbersB = { 1, 3, 5, 7, 8 };

            var pairs = from a in numbersA
                        from b in numbersB
                        where a < b
                        select new { A = a,  B =b};

            Console.WriteLine("Pairs where a < b:");
            foreach (var pair in pairs)
            {
                Console.WriteLine($"{pair.A} is less than {pair.B}");
            }
        }
    }

}





