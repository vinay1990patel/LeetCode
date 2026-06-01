using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.BehaviouralDesignPatterns.StrategyPattern
{
    internal class ParallelApi : IcontentLicensingProcessApi // Concrete Implementation
    {
        public Task ExecuteAsync(string licensing)
        {
            Console.WriteLine($"Parallel Execution :{licensing}");
            return Task.CompletedTask;
        }

        public Task<string> GetOrCreateProcessAsnyc()
        {
            return Task.FromResult("Parallel Process Created");
        }

        public Task StartAsync()
        {
            Console.WriteLine("Parallel task Started");
            return Task.CompletedTask;
        }
    }
}

