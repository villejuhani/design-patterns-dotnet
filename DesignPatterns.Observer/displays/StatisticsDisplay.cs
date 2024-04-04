namespace DesignPatterns.Observer.displays;

public class StatisticsDisplay : IObserver, IDisplayElement
{
    private float _maxTemperature = float.MinValue;
    private float _minTemperature = float.MaxValue;
    private float _temperatureSum = 0.0f;
    private int _temperatureReadings;
    private readonly WeatherData _weatherData;

    public StatisticsDisplay(WeatherData weatherData)
    {
        _weatherData = weatherData;
        _weatherData.RegisterObserver(this);
    }
    public void Update()
    {
        var temp = _weatherData.Temperature;
        _temperatureSum += temp;
        _temperatureReadings++;

        if (temp > _maxTemperature)
            _maxTemperature = temp;

        if (temp < _minTemperature)
            _minTemperature = temp;
        
        Display();
    }

    public void Display()
    {
        Console.WriteLine($"Avg/Min/Max temperature = {_temperatureSum / _temperatureReadings}/{_minTemperature}/{_maxTemperature}");
    }
}