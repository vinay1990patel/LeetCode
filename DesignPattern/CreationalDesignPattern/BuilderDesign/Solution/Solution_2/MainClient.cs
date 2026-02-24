using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.CreationalDesignPattern.BuilderDesign.Solution.Solution_2
{
    internal class MainClientSoultion2
    {
        public static void main()
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine($"With Builder pattern solution 2");
            Console.ResetColor();
            // Using Builder Pattern (nested class)
            HttpRequest request = new HttpRequest.HttpRequestBuilder()
                .WithUrl("https://api.example2.com")
                .WithMethod("POST")
                .WithHeader("Content-Type", "application/json")
                .WithHeader("Accept", "application/json")
                .WithQueryParam("key", "12345")
                .WithBody("{\"name\": \"vinay\"}")
                .WithTimeout(60)
                .Build();

            request.Execute(); // Guaranteed to be in a consistent state
        }
    }
}
