using DesignPatterns.Strategy.Behaviors.Interfaces;

namespace DesignPatterns.Strategy.Behaviors;

public class FakeQuack : IQuackBehavior
{
    public void Quack()
    {
        Console.WriteLine("Qwak");
    }
}