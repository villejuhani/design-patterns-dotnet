using DesignPatterns.Strategy.Behaviors;

namespace DesignPatterns.Strategy.Models.Ducks;

public class RedHeadDuck : Duck
{
    public RedHeadDuck()
    {
        FlyBehavior = new FlyWithWings();
        QuackBehavior = new DefaultQuack();
    }

    public override void display()
    {
        Console.WriteLine("I'm a real Red Headed duck");
    }
}