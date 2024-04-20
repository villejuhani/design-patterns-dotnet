using DesignPatterns.Factory.AbstractFactory.PizzaIngredients.Interfaces;

namespace DesignPatterns.Factory.AbstractFactory.PizzaIngredients;

public class NYPizzaIngredientFactory : IPizzaIngredientFactory
{
    public IDough CreateDough()
    {
        return new ThinCrustDough();
    }

    public ISauce CreateSauce()
    {
        return new MarinaraSauce();
    }

    public ICheese CreateCheese()
    {
        return new ReggianoCheese();
    }

    public IVeggies[] CreateVeggies()
    {
        IVeggies[] veggies =
        [
            new Garlic(),
            new Onion(),
            new Mushroom()
        ];
        return veggies;
    }
}