using DesignPatterns.StrategyPattern.Behaviors;

namespace DesignPatterns.StrategyPattern.Models.Ducks;

public class MallardDuck : Duck
{
    public MallardDuck()
    {
        FlyBehavior = new FlyWithWings();
        QuackBehavior = new DefaultQuack();
    }
    
    public override void display()
    {
        Console.WriteLine("I'm a real Mallard duck");
    }
}