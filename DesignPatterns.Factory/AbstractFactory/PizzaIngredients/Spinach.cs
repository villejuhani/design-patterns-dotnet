using DesignPatterns.Factory.AbstractFactory.PizzaIngredients.Interfaces;

namespace DesignPatterns.Factory.AbstractFactory.PizzaIngredients;

public class Spinach : IVeggies
{
    public override string ToString()
    {
        return "Spinach";
    }
}