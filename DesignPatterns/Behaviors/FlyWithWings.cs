using DesignPatterns.StrategyPattern.Behaviors.Interfaces;

namespace DesignPatterns.StrategyPattern.Behaviors;

public class FlyWithWings : IFlyBehavior
{
    public void Fly()
    {
        Console.WriteLine("I'm flying!!");
    }
}