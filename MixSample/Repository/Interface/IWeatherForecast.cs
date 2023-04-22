namespace MixSample.Repository.Interface
{
    public interface IWeatherForecast
    {


        IEnumerable<WeatherForecast> GetForecasts();
       

    }
}