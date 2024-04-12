namespace DesignPatterns.Decorator.Condiments;

public abstract class CondimentDecorator : Beverage
{
    protected Beverage Beverage;
    public abstract override string Description { get; set; }

    public override Size BeverageSize
    {
        get => Beverage.BeverageSize;
        set{}
    }
}