using DesignPatterns.Factory.AbstractFactory.PizzaIngredients.Interfaces;

namespace DesignPatterns.Factory.AbstractFactory.PizzaIngredients;

public class BlackOlives : IVeggies
{
    public override string ToString()
    {
        return "Black Olives";
    }
}