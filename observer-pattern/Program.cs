
namespace observer_pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            WeatherData weatherData = new WeatherData();
            CurrentConditions currentDisplay = new CurrentConditions(weatherData);

            weatherData.SetMeasurementsChanged(80, 65, 30.4f);
            weatherData.SetMeasurementsChanged(82, 70, 29.2f);
            weatherData.SetMeasurementsChanged(78, 90, 29.2f);

        }
    }
}
