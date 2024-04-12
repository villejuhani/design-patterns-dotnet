﻿namespace DesignPatterns.Decorator.Condiments;

public class Milk : CondimentDecorator
{
    public Milk(Beverage beverage)
    {
        Beverage = beverage;
    }

    public override string Description
    {
        get => $"{Beverage.Description} , Milk";
        set {}
    }
    
    public override double Cost()
    {
        return Beverage.BeverageSize switch
        {
            Size.Tall => Beverage.Cost() + 0.05,
            Size.Grande => Beverage.Cost() + 0.10,
            Size.Venti => Beverage.Cost() + 0.15,
            _ => Beverage.Cost()
        };
    }
}