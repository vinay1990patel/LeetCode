using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.BehaviouralDesignPatterns.StrategyPattern
{
    public interface IcontentLicensingProcessApi  // Strategy Contract
    {
        Task<string> GetOrCreateProcessAsnyc();
        Task ExecuteAsync(string licensing);
        Task StartAsync();
    }
}
