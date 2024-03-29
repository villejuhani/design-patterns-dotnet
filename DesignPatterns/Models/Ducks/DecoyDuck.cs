using DesignPatterns.StrategyPattern.Behaviors;
using DesignPatterns.StrategyPattern.Behaviors.Interfaces;

namespace DesignPatterns.StrategyPattern.Models.Ducks;

public class DecoyDuck : Duck
{
    public DecoyDuck(IFlyBehavior flyBehavior, IQuackBehavior quackBehavior)
    {
        FlyBehavior = new FlyNoWay();
        QuackBehavior = new MuteQuack();
    }
    
    public override void display()
    {
        Console.WriteLine("I'm a decoy");
    }
    
}