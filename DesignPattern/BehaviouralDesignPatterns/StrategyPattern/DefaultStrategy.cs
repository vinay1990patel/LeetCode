using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.BehaviouralDesignPatterns.StrategyPattern
{
    public class ContentLicesingProcess : IcontentLicensingProcessApi // Concrete Implementation
    {
        public Task ExecuteAsync(string licensing)
        {
            Console.WriteLine($"Default Execution :{licensing}");
            return Task.CompletedTask;
        }

        public Task<string> GetOrCreateProcessAsnyc()
        {
            return Task.FromResult("Default Process Created");
        }

        public Task StartAsync()
        {
            Console.WriteLine("Default Task Started");
            return Task.CompletedTask;
        }
    }
}
