namespace DesignPatterns.Decorator.Condiments;

public class Mocha : CondimentDecorator
{
    public Mocha(Beverage beverage)
    {
        Beverage = beverage;
    }

    public override string Description
    {
        get => Beverage.Description + ", Mocha";
        set{}
    }

    public override double Cost()
    {
        return Beverage.BeverageSize switch
        {
            Size.Tall => Beverage.Cost() + 0.15,
            Size.Grande => Beverage.Cost() + 0.20,
            Size.Venti => Beverage.Cost() + 0.25,
            _ => Beverage.Cost()
        };
    }
}