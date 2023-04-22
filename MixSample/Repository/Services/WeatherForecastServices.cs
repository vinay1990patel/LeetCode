using MixSample.DbContextLayer;
using MixSample.Repository.Interface;

namespace MixSample.Repository.Services
{
    public class WeatherForecastServices : IWeatherForecast
    {
        private static readonly string[] Summaries = new[]
       {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

       
       public IEnumerable<WeatherForecast> GetForecasts()
        {

            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
          .ToArray();

           
        }
        
    }
}
