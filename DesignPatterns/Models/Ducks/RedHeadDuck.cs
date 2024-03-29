using DesignPatterns.StrategyPattern.Behaviors;

namespace DesignPatterns.StrategyPattern.Models.Ducks;

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