namespace DesignPatterns.Decorator;

public abstract class Beverage
{
    public enum Size
    {
        Tall, Grande, Venti
    }

    public virtual Size BeverageSize { get; set; } = Size.Tall;
    public virtual string Description { get; set; } = "unknown beverage";
    public abstract double Cost();
}