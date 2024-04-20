using DesignPatterns.Factory.AbstractFactory.PizzaIngredients.Interfaces;

namespace DesignPatterns.Factory.AbstractFactory.PizzaIngredients;

public class ThinCrustDough : IDough
{
    public override string ToString()
    {
        return "Thin Crust Dough";
    }
}