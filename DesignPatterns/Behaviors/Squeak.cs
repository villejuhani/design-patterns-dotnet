using DesignPatterns.StrategyPattern.Behaviors.Interfaces;

namespace DesignPatterns.StrategyPattern.Behaviors;

public class Squeak : IQuackBehavior
{
    public void Quack()
    {
        Console.WriteLine("Squeak");
    }
}