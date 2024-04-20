using DesignPatterns.Factory.AbstractFactory.PizzaIngredients.Interfaces;

namespace DesignPatterns.Factory.AbstractFactory.PizzaIngredients;

public class Onion : IVeggies
{
    public override string ToString()
    {
        return "Onion";
    }
}