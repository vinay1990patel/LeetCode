// See https://aka.ms/new-console-template for more information
using EnitityFrameWork;

Console.WriteLine("****************************** Lambda ****************************************");

int result = Lambda.Multiply(2, 4);
Console.WriteLine(result);

int result1 = Lambda.multiplybyTen(5);
Console.WriteLine(result1);

int result2 = Lambda.NextNumber(4);
Console.WriteLine(result2);

 LINQ.LinqUsingLambda();


Console.WriteLine("****************************** Nth Salary by Link ****************************************");

LINQ.NthSalary();
Console.WriteLine("****************************** Normal String Index ****************************************");

LINQ.LinqForStringIndex();

Console.WriteLine("****************************** LINQ - lazy and eager execution ****************************************");
LazyAndEagerExecution.LazyExecution();
LazyAndEagerExecution.EagerExecution();
LINQ.NumberIndex();
LINQ.SelectMultiPleInputSequance();


Console.ReadLine();