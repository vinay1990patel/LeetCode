using Azure;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace LeetCode.CSharp
{
    internal class WebClient
    {

        public class ApiResponse
        {
           public int Id { get; set; }
           public string todo { get; set; }
           public bool completed { get; set; }
           public string userId { get; set; }

        }

        public static async Task GetUsingHttpClient()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://dummyjson.com/todos");
            HttpResponseMessage httpResponseMessage = await client.GetAsync(client.BaseAddress);
            httpResponseMessage.EnsureSuccessStatusCode();
            string responseBody = await httpResponseMessage.Content.ReadAsStringAsync();
            Console.WriteLine(responseBody);
            // Example: parse JSON and use LINQ to select todo titles
            var serilaizeData = JsonSerializer.Deserialize<ApiResponse[]>(responseBody);
            var todos = serilaizeData.Select(x => x.userId);
            Parallel.ForEach(todos, todo => {
                Console.WriteLine(todo);
            });
           


           
        }

       public static async Task GetUsingRestClinetAsync()
        {
            var client = new RestClient("https://dummyjson.com/todos");
            var request = new RestRequest("userId", Method.Get);
            var response = await client.ExecuteAsync(request);
            Console.WriteLine(response.Content);
        }
    }
}
