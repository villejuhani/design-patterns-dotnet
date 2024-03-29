using DesignPatterns.Strategy.Behaviors;

namespace DesignPatterns.Strategy.Models.Ducks;

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