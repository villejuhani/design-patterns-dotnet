using DesignPatterns.Factory.AbstractFactory.PizzaIngredients.Interfaces;

namespace DesignPatterns.Factory.AbstractFactory.PizzaIngredients;

public class Garlic : IVeggies
{
    public override string ToString()
    {
        return "Garlic";
    }
}