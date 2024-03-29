using DesignPatterns.Strategy.Behaviors.Interfaces;

namespace DesignPatterns.Strategy.Behaviors;

public class DefaultQuack : IQuackBehavior
{
    public void Quack()
    {
        Console.WriteLine("Quack");
    }
}