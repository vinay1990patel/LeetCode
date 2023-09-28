// See https://aka.ms/new-console-template for more information
using multithreadAndAsyncParallel_programming;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
 static void Main()
{
    Thread Singlethread1 =  Thread.CurrentThread;
    Singlethread1.Priority= ThreadPriority.Normal;








}

SingleThread.m1(5);
Console.WriteLine("method 1 execution is completed");
SingleThread.m2();
Console.WriteLine("method 2 execution is completed");
SingleThread.m3();



Console.WriteLine("**********************************************************************************");


Thread t1 = new Thread(MultiThread.m1)
{
    Name = "thread 1"
};

Thread t2 = new Thread(MultiThread.m2)
{
    Name = "thread 2"
};

Thread t3 = new Thread(MultiThread.m3)
{
    Name = "thread 3"
};

// executing the tread.

t1.Start();
t2.Start();
t3.Start();

ThreadStart s1 = new ThreadStart(MultiThread.m1);// ThreadStart is a delegate

ThreadStart s2 = () => MultiThread.m1();  

ParameterizedThreadStart s3 = new ParameterizedThreadStart(SingleThread.m1);

Thread th = new Thread(s3);
th.Start(10);


Console.WriteLine("**********************************************************************************");

Console.WriteLine("Main Thread Started executing.");

Thread t11 = new Thread(MethodsInThreading.Method1);
t11.Start();

Thread t22 = new Thread(MethodsInThreading.Method2);

t22.Start();

if (t11.Join(2000))
{
    Console.WriteLine("Method1 execution completed");
}
if (t11.IsAlive)
{
    Console.WriteLine(" t1 is alive");
}

t22.Join();


Console.WriteLine("Main Thread completed execution.");


Semaphore s = new Semaphore(1, 1);




Console.WriteLine("******************************************** Locking **************************************");

int sum = 0;
Thread t111 = new Thread(locking.sharedMethod);
Thread t12 = new Thread(locking.sharedMethod);
Thread t13 = new Thread(locking.sharedMethod);
t111.Start();
t12.Start();
t13.Start();
Console.WriteLine(locking.sum);


Console.WriteLine("******************************************** Monitor **************************************");

Console.WriteLine(" *************************************************** Thred Pooling ********************************************");

Console.WriteLine("Thred pool stared ");




for (int i = 0; i <= 5; i++)
{

    ThreadPool.QueueUserWorkItem(new WaitCallback(threadPoools.ThreadPoolMethod));

}

Console.WriteLine(" *************************************************** Asynchronous programming ********************************************");

Task<string> task = Task.Run(() =>
{
    return AsyncProgram.AsnycMethod(5);
}).ContinueWith((info) =>
{
    return "This is continue 1 :" + info.Result;
}).ContinueWith((p) =>
{
    return "This is continue 2 :" + p.Result;
});

task.Wait();
Console.WriteLine("Task Result " + task.Result);


Console.WriteLine(" *************************************************** Asyn Await Exception Handling ********************************************");

Task.Run(async () => 
{
    try { 
    await AsyncProgram.MethodWithException();
    }
    catch (Exception ex)
    {

    }
});


Console.WriteLine(" *************************************************** Task Parallel Labrary  ********************************************");
TaskParallelPrograming.TaskParallelLab();
Parallel.Invoke(() =>
{
    TaskParallelPrograming.InvokeMethod(2);
    TaskParallelPrograming.InvokeMethod("vinay");
    TaskParallelPrograming.InvokeMethod(2);
    TaskParallelPrograming.InvokeMethod("vinay");
});

TaskParallelPrograming.PLINQMethod();

Console.WriteLine(" ***************************************************  For Loop  ********************************************");

ParallelForLoop.ParallelForLoopMethod();

Console.WriteLine(" ***************************************************  ForEach Loop  ********************************************");

ParallelForLoopEach.ParallelForLoopEachMethod();

Console.WriteLine(" ***************************************************  Parallel Invoke Loop  ********************************************");

ParallelInvoke.ParallelInvokeMethod();

Console.WriteLine(" ***************************************************  Parallel Invoke Loop  ********************************************");

AsParallel.AsParallelForAll();


Console.WriteLine(" ***************************************************  Asyc And Await and exception handling  ********************************************");

AsyncProgramAndErrorHandling.GetDataFromCollection();

Console.WriteLine(" ***************************************************  test ********************************************");

Console.ReadLine();








class locking
{
    public static int sum = 0;
    public static object _loc = new object();
    public static void sharedMethod()
    {

        for (int i = 0; i < 5000; i++)
        {
            //lock(_loc)
            //{ 
            //sum++;
            //}


            // or 
            Monitor.Enter(_loc);
            try
            {
                sum++;
            }
            catch
            {

            }
            finally
            {
                Monitor.Exit(_loc);
            }



        }

    }
}


class MethodsInThreading
{
    public static void Method1()
    {
        Console.WriteLine("Method 1");
        Thread.Sleep(5000);
        Console.WriteLine("awaiting");
    }

    public static void Method2()
    {
        Console.WriteLine("Method 2");
    }
}


/// <summary>
/// Thred Pools
/// </summary>
class threadPoools
{



    public static void ThreadPoolMethod(object obj)
    {
        Thread thread = Thread.CurrentThread;
        string message = $"Background: {thread.IsBackground}, thread pool: {thread.IsThreadPoolThread}, thread Id {thread.ManagedThreadId}";
        Console.WriteLine(message);
    }
}



/// <summary>
/// Async Method
/// </summary>
class AsyncProgram
{

    public static int AsnycMethod(int a)
    {
        int sum = 0;
        for (int i = 0; i < a; i++)
        {
            sum = sum + i;
        }



        return sum;
    }


    public static int SynchronousTask()
    {
        int sum = 0;
        for (int i = 0; i < 10000000; i++)
        {
            sum = sum + i;
        }
        return sum;
    }


    public static async Task UseMethodWithAsyncVoid()
    {
        try
        {
            await MethodWithException();
        }
        catch (Exception e)
        {
            Console.WriteLine("Ex Message" + e.Message);
        }
    }

    public static async Task MethodWithException()
    {
        await Task.Delay(1000);
        throw new Exception("The control doesn't hit the catch line if async void is used.");
    }





}


class TaskParallelPrograming
{



    public static void TaskParallelLab()
    {
        ParallelOptions parallelOptions = new ParallelOptions()
        {
            MaxDegreeOfParallelism = -1
        };
        int length = 10;
        Console.WriteLine("****** Simple for loop ******");
        for (int i = 0; i < length; i++)
        {
            Console.WriteLine($"Serial no : {i} ThredID {Thread.CurrentThread.ManagedThreadId}");
        }

        Console.WriteLine("****** Parallel for loop ******");

        Parallel.For(0, length, parallelOptions, count =>
        {
            Console.WriteLine($"Serial no : {count} ThreadId {Thread.CurrentThread.ManagedThreadId}");
        });





    }


    public static void InvokeMethod(int a)
    {
        Console.WriteLine("number is :" + a);
    }

    public static void InvokeMethod(string a)
    {
        Console.WriteLine("number is :" + a);
    }
   
    public static void PLINQMethod()
    {
        Console.WriteLine("****** PLINQ ******");
        var Source = Enumerable.Range(0, 500);

        var result = from num in Source.AsParallel().WithDegreeOfParallelism(2)
                     where num % 2 == 0
                     select num;

        Console.WriteLine($"the count is : {result.Count()}");


    }
}







