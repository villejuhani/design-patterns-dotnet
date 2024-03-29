using DesignPatterns.StrategyPattern.Behaviors.Interfaces;

namespace DesignPatterns.StrategyPattern.Behaviors;

public class FlyNoWay : IFlyBehavior
{
    public void Fly()
    {
        Console.WriteLine("I can't fly");
    }
}