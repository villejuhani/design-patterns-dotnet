using DesignPatterns.Factory.AbstractFactory.PizzaIngredients.Interfaces;

namespace DesignPatterns.Factory.AbstractFactory.PizzaIngredients;

public class MarinaraSauce : ISauce
{
    public override string ToString()
    {
        return "Marinara Sauce";
    }
}