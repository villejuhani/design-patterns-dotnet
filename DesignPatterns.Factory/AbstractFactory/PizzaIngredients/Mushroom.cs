using DesignPatterns.Factory.AbstractFactory.PizzaIngredients.Interfaces;

namespace DesignPatterns.Factory.AbstractFactory.PizzaIngredients;

public class Mushroom : IVeggies
{
    public override string ToString()
    {
        return "Mushroom";
    }
}