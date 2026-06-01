using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.BehaviouralDesignPatterns.StrategyPattern
{
    public class BaseLineApi : IcontentLicensingProcessApi // Concrete Implementation
    {
        public Task ExecuteAsync(string licensing)
        {
            Console.WriteLine($"Baseline Execution :{licensing}");
            return Task.CompletedTask;
        }

        public Task<string> GetOrCreateProcessAsnyc()
        {
            return Task.FromResult("Baseline Process Created");
        }

        public Task StartAsync()
        {
            Console.WriteLine("Baseline task Started");
            return Task.CompletedTask;
        }
    }
}
