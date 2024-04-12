namespace DesignPatterns.Decorator.Condiments;

public class Soy : CondimentDecorator
{
    public Soy(Beverage beverage)
    {
        Beverage = beverage;
    }

    public override string Description
    {
        get => Beverage.Description + ", Soy";
        set{}
    }

    public override double Cost()
    {
        return Beverage.BeverageSize switch
        {
            Size.Tall => Beverage.Cost() + 0.10,
            Size.Grande => Beverage.Cost() + 0.15,
            Size.Venti => Beverage.Cost() + 0.20,
            _ => Beverage.Cost()
        };
    }
}