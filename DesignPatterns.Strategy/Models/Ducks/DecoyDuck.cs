using DesignPatterns.Strategy.Behaviors;
using DesignPatterns.Strategy.Behaviors.Interfaces;

namespace DesignPatterns.Strategy.Models.Ducks;

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