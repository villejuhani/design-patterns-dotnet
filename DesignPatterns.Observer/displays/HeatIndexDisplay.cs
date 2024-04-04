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
    
    public void Update()
    {
        var fahrenheit = WeatherCalculations.ConvertCelsiusToFahrenheit(_weatherData.Temperature);
        _heatIndex = WeatherCalculations.CalculateHeatIndex(fahrenheit, _weatherData.Humidity);
        
        Display();
    }

    public void Display()
    {
        Console.WriteLine($"Heat index is {_heatIndex}");
    }
}