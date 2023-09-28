using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace EnitityFrameWork
{
    internal class LazyAndEagerExecution
    {

        public static void LazyExecution()
        {
            // Sequence operators form first-class queries that
            // are not executed until you enumerate over them.

            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            int i = 0;
            var q = from n in numbers
                    select ++i;

            // Note, the local variable 'i' is not incremented
            // until each element is evaluated (as a side-effect):
            foreach (var v in q)
            {
                Console.WriteLine($"v = {v}, i = {i}");
            }
        }


      
        public static void EagerExecution  ()
        {

            /*  Eager loading
            Eager loading is the process whereby a query for one type of entity also loads related entities as part of the query, 
            so that we don't need to execute a separate query for related entities. 
            Eager loading is achieved using the Include() method.


            using (var context = new SchoolDBEntities())
                {
                   var stud1 = (from s in context.Students.Include("Standard")
                   where s.StudentName == "Bill"
                   select s).FirstOrDefault<Student>();
                 }


             
             */


            /* Lazy Loading 
             
            Lazy loading is delaying the loading of related data, until you specifically request for it
            
            using (var ctx = new SchoolDBEntities())
               {
                       //Loading students only
                       IList<Student> studList = ctx.Students.ToList<Student>();

                       Student std = studList[0];

                      //Loads Student address for particular Student only (seperate SQL query)
                      StudentAddress add = std.StudentAddress;
                }
            
             */


          



            // Methods like ToList() cause the query to be
            // executed immediately, caching the results.

            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            int i = 0;
            var q = (from n in numbers
                     select ++i)
                     .ToList();

            // The local variable i has already been fully
            // incremented before we iterate the results:

            Console.WriteLine( "********************** Eager Loading *********************");
            foreach (var v in q)
            {
                Console.WriteLine($"v = {v}, i = {i}");
            }
        }


        /*  Explicit Loading

          Even with lazy loading disabled (in EF 6), it is still possible to lazily load related entities, 
          but it must be done with an explicit call. Use the Load() method to load related entities explicitly

          using (var context = new SchoolContext())
{
                        var student = context.Students
                        .Where(s => s.FirstName == "Bill")
                        .FirstOrDefault<Student>();

                        context.Entry(student).Reference(s => s.StudentAddress).Load(); // loads StudentAddress
                        context.Entry(student).Collection(s => s.StudentCourses).Load(); // loads Courses collection 
}   

           */
    }



}
