using DesignPatterns.Factory.AbstractFactory.PizzaIngredients.Interfaces;

namespace DesignPatterns.Factory.AbstractFactory;

public class CheesePizza : Pizza
{
    private readonly IPizzaIngredientFactory _pizzaIngredientFactory;
    public CheesePizza(IPizzaIngredientFactory pizzaIngredientFactory)
    {
        _pizzaIngredientFactory = pizzaIngredientFactory;
    }

    public override void Prepare()
    {
        Console.WriteLine($"Preparing {Name}");
        Dough = _pizzaIngredientFactory.CreateDough();
        Sauce = _pizzaIngredientFactory.CreateSauce();
        Cheese = _pizzaIngredientFactory.CreateCheese();
    }
}