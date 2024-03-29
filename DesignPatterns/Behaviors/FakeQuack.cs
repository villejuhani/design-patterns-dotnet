using DesignPatterns.StrategyPattern.Behaviors.Interfaces;

namespace DesignPatterns.StrategyPattern.Behaviors;

public class FakeQuack : IQuackBehavior
{
    public void Quack()
    {
        Console.WriteLine("Qwak");
    }
}