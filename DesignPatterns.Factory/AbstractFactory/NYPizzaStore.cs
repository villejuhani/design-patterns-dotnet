using DesignPatterns.Factory.AbstractFactory.PizzaIngredients;
using DesignPatterns.Factory.AbstractFactory.PizzaIngredients.Interfaces;

namespace DesignPatterns.Factory.AbstractFactory;

public class NYPizzaStore : PizzaStore
{
    protected override Pizza CreatePizza(string type)
    {
        Pizza pizza;
        IPizzaIngredientFactory pizzaIngredientFactory = new NYPizzaIngredientFactory();

        switch (type)
        {
            case "cheese":
            {
                pizza = new CheesePizza(pizzaIngredientFactory);
                pizza.Name = "New York Style Cheese Pizza";
                break;
            }
            case "veggie":
            {
                pizza = new VeggiePizza(pizzaIngredientFactory);
                pizza.Name = "New York Style Veggie Pizza";
                break;
            }
            default: return null!;
        }

        return pizza;
    }
}