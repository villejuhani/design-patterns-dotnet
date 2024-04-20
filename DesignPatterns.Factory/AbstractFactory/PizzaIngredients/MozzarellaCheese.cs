using DesignPatterns.Factory.AbstractFactory.PizzaIngredients.Interfaces;

namespace DesignPatterns.Factory.AbstractFactory.PizzaIngredients;

public class MozzarellaCheese : ICheese
{
    public override string ToString()
    {
        return "Mozzarella";
    }
}