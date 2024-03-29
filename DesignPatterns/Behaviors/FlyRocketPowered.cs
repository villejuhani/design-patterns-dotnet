using DesignPatterns.StrategyPattern.Behaviors.Interfaces;

namespace DesignPatterns.StrategyPattern.Behaviors;

public class FlyRocketPowered : IFlyBehavior
{
    public void Fly()
    {
        Console.WriteLine("I'm flying with a rocket");
    }
}