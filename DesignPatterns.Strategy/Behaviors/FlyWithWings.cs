using DesignPatterns.Strategy.Behaviors.Interfaces;

namespace DesignPatterns.Strategy.Behaviors;

public class FlyWithWings : IFlyBehavior
{
    public void Fly()
    {
        Console.WriteLine("I'm flying!!");
    }
}