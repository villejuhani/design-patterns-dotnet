﻿namespace DesignPatterns.Decorator;

public class Espresso : Beverage
{
    public Espresso()
    {
        Description = "Espresso";
    }
    public override double Cost()
    {
        return 1.99;
    }
}