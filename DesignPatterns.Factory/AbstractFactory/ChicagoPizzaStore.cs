using DesignPatterns.Factory.AbstractFactory.PizzaIngredients;
using DesignPatterns.Factory.AbstractFactory.PizzaIngredients.Interfaces;

namespace DesignPatterns.Factory.AbstractFactory;

public class ChicagoPizzaStore : PizzaStore
{
    protected override Pizza CreatePizza(string type)
    {
        Pizza pizza;
        IPizzaIngredientFactory pizzaIngredientFactory = new ChicagoPizzaIngredientFactory();

        switch (type)
        {
            case "cheese":
            {
                pizza = new CheesePizza(pizzaIngredientFactory);
                pizza.Name = "Chicago Style Cheese Pizza";
                break;
            }
            case "veggie":
            {
                pizza = new VeggiePizza(pizzaIngredientFactory);
                pizza.Name = "Chicago Style Veggie Pizza";
                break;
            }
            default: return null!;
        }

        return pizza;
    }
}