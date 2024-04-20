using DesignPatterns.Factory.AbstractFactory.PizzaIngredients.Interfaces;

namespace DesignPatterns.Factory.AbstractFactory.PizzaIngredients;

public class ChicagoPizzaIngredientFactory : IPizzaIngredientFactory
{
    public IDough CreateDough()
    {
        return new ThickCrustDough();
    }

    public ISauce CreateSauce()
    {
        return new PlumTomatoSauce();
    }

    public ICheese CreateCheese()
    {
        return new MozzarellaCheese();
    }

    public IVeggies[] CreateVeggies()
    {
        IVeggies[] veggies =
        [
            new Spinach(), new BlackOlives()
        ];
        return veggies;
    }
}