using DesignPatterns.Observer.displays;

namespace DesignPatterns.Observer;

internal abstract class WeatherStation
{
    private static void Main()
    {
        WeatherData weatherData = new();

        CurrentConditionsDisplay currentConditionsDisplay = new(weatherData);
        StatisticsDisplay statisticsDisplay = new(weatherData);
        
        weatherData.SetMeasurements(20, 65, 30.4f);
        weatherData.SetMeasurements(24, 70, 29.2f);
        weatherData.SetMeasurements(17, 90, 39.2f);
    }
}