using DesignPatterns.Factory.AbstractFactory.PizzaIngredients.Interfaces;

namespace DesignPatterns.Factory.AbstractFactory.PizzaIngredients;

public class ThickCrustDough : IDough
{
    public override string ToString()
    {
        return "Thick Crust Dough";
    }
}