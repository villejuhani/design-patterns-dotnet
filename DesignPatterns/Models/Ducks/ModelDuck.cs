using DesignPatterns.StrategyPattern.Behaviors;

namespace DesignPatterns.StrategyPattern.Models.Ducks;

public class ModelDuck : Duck
{
    public ModelDuck()
    {
        FlyBehavior = new FlyNoWay();
        QuackBehavior = new DefaultQuack();
    }
    
    public override void display()
    {
        Console.WriteLine("I'm a model duck");
    }
}