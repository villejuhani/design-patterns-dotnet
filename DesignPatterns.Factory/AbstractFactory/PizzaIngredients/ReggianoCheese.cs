using DesignPatterns.Factory.AbstractFactory.PizzaIngredients.Interfaces;

namespace DesignPatterns.Factory.AbstractFactory.PizzaIngredients;

public class ReggianoCheese : ICheese
{
    public override string ToString()
    {
        return "Reggiano Cheese";
    }
}