using DesignPatterns.StrategyPattern.Behaviors;
using DesignPatterns.StrategyPattern.Behaviors.Interfaces;

namespace DesignPatterns.StrategyPattern.Models.Ducks;

public class RubberDuck : Duck
{
    public RubberDuck()
    {
        FlyBehavior = new FlyNoWay();
        QuackBehavior = new Squeak();
    }
    
    public RubberDuck(IFlyBehavior flyBehavior, IQuackBehavior quackBehavior)
    {
        FlyBehavior = flyBehavior;
        QuackBehavior = quackBehavior;
    }
    
    public override void display()
    {
        Console.WriteLine("I'm a rubber duckie");
    }
}