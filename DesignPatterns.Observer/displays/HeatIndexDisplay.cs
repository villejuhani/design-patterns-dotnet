namespace DesignPatterns.Observer.displays;

public class HeatIndexDisplay : IObserver, IDisplayElement
{
    private readonly WeatherData _weatherData;
    private float _heatIndex;
    
    public HeatIndexDisplay(WeatherData weatherData)
    {
        _weatherData = weatherData;
        _weatherData.RegisterObserver(this);
    }
    
    public void Update(float temp, float humidity, float pressure)
    {
        var fahrenheit = WeatherCalculations.ConvertCelsiusToFahrenheit(temp);
        _heatIndex = WeatherCalculations.CalculateHeatIndex(fahrenheit, humidity);
        
        Display();
    }

    public void Display()
    {
        Console.WriteLine($"Heat index is {_heatIndex}");
    }
}