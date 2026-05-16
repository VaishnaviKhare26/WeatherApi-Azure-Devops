using WeatherApi.Models;

namespace WeatherApi.Services
{
    public class WeatherService
    {
        public WeatherData GetWeather()
        {
            return new WeatherData
            {
                City = "Pune",
                Temperature = 32,
                Condition = "Sunny"
            };
        }
    }
}
