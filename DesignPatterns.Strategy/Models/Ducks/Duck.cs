using DesignPatterns.Strategy.Behaviors.Interfaces;

namespace DesignPatterns.Strategy.Models.Ducks;

public abstract class Duck
{
    protected IFlyBehavior FlyBehavior;
    protected IQuackBehavior QuackBehavior;

    public Duck() {
    }

    public void setFlyBehavior(IFlyBehavior fb) {
        FlyBehavior = fb;
    }

    public void setQuackBehavior(IQuackBehavior qb) {
        QuackBehavior = qb;
    }

    public abstract void display();

    public void performFly() {
        FlyBehavior.Fly();
    }

    public void performQuack() {
        QuackBehavior.Quack();
    }

    public void swim() {
        Console.WriteLine("All ducks float, even decoys!");
    }
}