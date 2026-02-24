using System;
using System.Collections.Generic;

namespace DesignPattern.CreationalDesignPattern.BuilderDesign.Solution.Solution_2
{
    
    internal class HttpRequest
    {
        // Properties are read-only to consumers (immutable after build).
        public string Url { get; private set; } = string.Empty;
        public string Method { get; private set; } = "GET";
        public Dictionary<string, string> Headers { get; private set; } = new();
        public Dictionary<string, string> QueryParams { get; private set; } = new();
        public string Body { get; private set; } = string.Empty;
        public int Timeout { get; private set; }

        // Private constructor - only Builder can create instances.
        private HttpRequest()
        {
            Headers = new Dictionary<string, string>();
            QueryParams = new Dictionary<string, string>();
            Body = string.Empty;
            Timeout = 30; // default
            Method = "GET";
        }

        // Simulated execution of the HTTP request.
        public void Execute()
        {
            Console.WriteLine($"Executing {Method} request to {Url}");

            if (QueryParams.Count > 0)
            {
                Console.WriteLine("Query Parameters:");
                foreach (var param in QueryParams)
                {
                    Console.WriteLine($"  {param.Key}={param.Value}");
                }
            }

            Console.WriteLine("Headers:");
            foreach (var header in Headers)
            {
                Console.WriteLine($"  {header.Key}: {header.Value}");
            }

            if (!string.IsNullOrEmpty(Body))
            {
                Console.WriteLine($"Body: {Body}");
            }

            Console.WriteLine($"Timeout: {Timeout} seconds");
            Console.WriteLine("Request executed successfully!");
        }

        // Nested builder class
        public sealed class HttpRequestBuilder
        {
            private readonly HttpRequest _req;

            public HttpRequestBuilder()
            {
                _req = new HttpRequest();
            }

            public HttpRequestBuilder WithUrl(string url)
            {
                _req.Url = url ?? string.Empty;
                return this;
            }

            public HttpRequestBuilder WithMethod(string method)
            {
                _req.Method = string.IsNullOrEmpty(method) ? "GET" : method;
                return this;
            }

            public HttpRequestBuilder WithHeader(string key, string value)
            {
                if (key is null) throw new ArgumentNullException(nameof(key));
                _req.Headers[key] = value ?? string.Empty;
                return this;
            }

            public HttpRequestBuilder WithQueryParam(string key, string value)
            {
                if (key is null) throw new ArgumentNullException(nameof(key));
                _req.QueryParams[key] = value ?? string.Empty;
                return this;
            }

            public HttpRequestBuilder WithBody(string body)
            {
                _req.Body = body ?? string.Empty;
                return this;
            }

            public HttpRequestBuilder WithTimeout(int seconds)
            {
                if (seconds < 0) throw new ArgumentOutOfRangeException(nameof(seconds));
                _req.Timeout = seconds;
                return this;
            }

            public HttpRequest Build()
            {
                if (string.IsNullOrWhiteSpace(_req.Url))
                    throw new InvalidOperationException("URL cannot be empty.");

                // Optional: enforce defaults if not explicitly set
                if (string.IsNullOrEmpty(_req.Method)) _req.Method = "GET";
                if (_req.Timeout == 0) _req.Timeout = 30;

                // Return built, immutable object
                return _req;
            }
        }
    }
}