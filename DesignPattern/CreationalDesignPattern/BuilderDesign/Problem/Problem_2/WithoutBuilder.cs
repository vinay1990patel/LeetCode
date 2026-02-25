using System;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection.Metadata;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DesignPattern.CreationalDesignPattern.BuilderDesign.Problem.Problem_2
{
    /*
           * now problem with this constructor is not much convenient because if we need only few parameter among all
             then we need to create another constructor which will lead below problem.
           -> Constructor Explosion = too many constructor
           -> because to many parameter its difficult to manage 

     */
    internal class HttpRequest
    {
        // required
        public string Url { get; private set; }
        public string Method { get; private set; }
        public Dictionary<string, string> Headers { get; private set; }
        public Dictionary<string, string> QueryParams { get; private set; }
        public string? Body { get; private set; }
        public int Timeout { get; private set; }

        // 1-arg
        public HttpRequest(string url)
        {
            this.Url = url;
            this.Method = "GET";       // Default method
            this.Timeout = 30;         // Default timeout
            this.Headers = new Dictionary<string, string>();
            this.QueryParams = new Dictionary<string, string>();
        }

        // 2-args
        public HttpRequest(string url, string method)
        {
            this.Url = url;
            this.Method = method;
            this.Timeout = 30;
            this.Headers = new Dictionary<string, string>();
            this.QueryParams = new Dictionary<string, string>();
        }

        // 3-args
        public HttpRequest(string url, string method, int timeout)
        {
            this.Url = url;
            this.Method = method;
            this.Timeout = timeout;
            this.Headers = new Dictionary<string, string>();
            this.QueryParams = new Dictionary<string, string>();
        }

        // 4-args
        public HttpRequest(string url, string method, int timeout, Dictionary<string, string> headers)
        {
            this.Url = url;
            this.Method = method;
            this.Timeout = timeout;
            this.Headers = headers;
            this.QueryParams = new Dictionary<string, string>();
        }

        // 5-args
        public HttpRequest(string url, string method, int timeout, Dictionary<string, string> headers, Dictionary<string, string> queryParams)
        {
            this.Url = url;
            this.Method = method;
            this.Timeout = timeout;
            this.Headers = headers;
            this.QueryParams = queryParams;
        }

        // 6-args
        public HttpRequest(string url, string method, int timeout, Dictionary<string, string> headers, Dictionary<string, string> queryParams, string body)
        {
            this.Url = url;
            this.Method = method;
            this.Timeout = timeout;
            this.Headers = headers;
            this.QueryParams = queryParams;
        }

        // Setters (leads to mutable object)
        public void SetUrl(string url) => Url = url;
        public void SetMethod(string method) => Method = method;
        public void AddHeader(string key, string value) => Headers[key] = value;
        public void AddQueryParam(string key, string value) => QueryParams[key] = value;
        public void SetBody(string body) => Body = body;
        public void SetTimeout(int timeout) => Timeout = timeout;

        // Method to execute the HTTP request
        public void Execute()
        {
            Console.WriteLine($"Executing {Method} request to {Url}");

            if (QueryParams.Count > 0)
            {
                Console.WriteLine("Query Parameters:");
                foreach (var kv in QueryParams)
                {
                    Console.WriteLine($"  {kv.Key}={kv.Value}");
                }
            }

            Console.WriteLine("Headers:");
            foreach (var kv in Headers)
            {
                Console.WriteLine($"  {kv.Key}: {kv.Value}");
            }

            if (!string.IsNullOrEmpty(Body))
            {
                Console.WriteLine($"Body: {Body}");
            }

            Console.WriteLine($"Timeout: {Timeout} seconds");
            Console.WriteLine("Request executed successfully!");
        }
    }

    internal class WithoutBuilderProblem2
    {
        // Example usage demonstrating telescoping constructors and mutable setters
        public static void Main()
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine($"Without Builder pattern problem 2");
            Console.ResetColor();

            var request1 = new HttpRequest("https://api.example.com");
            var request2 = new HttpRequest("https://api.example.com", "POST");
            var request3 = new HttpRequest("https://api.example.com", "PUT", 60);

            var request4 = new HttpRequest("https://api.example.com");
            request4.SetMethod("POST");
            request4.AddHeader("Content-Type", "application/json");
            request4.AddQueryParam("key", "12345");
            request4.SetBody("{\"name\": \"vinay\"}");
            request4.SetTimeout(60);

            // The problem: if an important field is forgotten, object may be invalid.
            request4.Execute();
        }
    }
}