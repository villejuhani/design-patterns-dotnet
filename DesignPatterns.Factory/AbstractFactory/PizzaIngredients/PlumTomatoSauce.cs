using DesignPatterns.Factory.AbstractFactory.PizzaIngredients.Interfaces;

namespace DesignPatterns.Factory.AbstractFactory.PizzaIngredients;

public class PlumTomatoSauce : ISauce
{
    public override string ToString()
    {
        return "Plum Tomato Sauce";
    }
}