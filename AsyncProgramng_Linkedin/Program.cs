// See https://aka.ms/new-console-template for more information
using AsyncProgramng_Linkedin;


Console.WriteLine("Program statred executing");
Console.WriteLine(System.Threading.Thread.CurrentThread.ManagedThreadId);
 

 var httpClient = new HttpClient();
 var response = httpClient.GetAsync("https://www.linkedin.com/feed/");

response.ContinueWith(httpTask =>
{
    Console.WriteLine(System.Threading.Thread.CurrentThread.ManagedThreadId);

    var result = httpTask.Result;
    Console.WriteLine(result.StatusCode);
});

Console.WriteLine(System.Threading.Thread.CurrentThread.ManagedThreadId);
Console.WriteLine("Program is ready to take the input");
Console.ReadLine();
