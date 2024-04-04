namespace DesignPatterns.Observer.displays;

public class ForecastDisplay : IObserver, IDisplayElement
{
    private float _currentPressure;
    private float _lastPressure;
    private WeatherData _weatherData;

    public ForecastDisplay(WeatherData weatherData)
    {
        _weatherData = weatherData;
        _weatherData.RegisterObserver(this);
    }

    public void Update()
    {
        _lastPressure = _currentPressure;
        _currentPressure = _weatherData.Pressure;
        
        Display();
    }

    public void Display()
    {
        Console.Write("Forecast: ");
        if (_currentPressure > _lastPressure)
            Console.WriteLine("Improving weather on the way");
        if (_currentPressure < _lastPressure)
            Console.WriteLine("Watch out for cooler, rainy weather");
        if (Math.Abs(_currentPressure - _lastPressure) == 0)
            Console.WriteLine("Forecast: More of the same");
    }
}