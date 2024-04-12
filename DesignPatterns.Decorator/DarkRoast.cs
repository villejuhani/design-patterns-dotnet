namespace DesignPatterns.Decorator;

public class DarkRoast : Beverage
{
    public DarkRoast()
    {
        Description = "Most excellent dark roast";
    }

    public override double Cost()
    {
        return 0.99;
    }
}