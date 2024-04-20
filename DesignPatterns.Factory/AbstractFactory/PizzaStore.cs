namespace DesignPatterns.Factory.AbstractFactory;

public abstract class PizzaStore
{
    public Pizza OrderPizza(string type)
    {
        var pizza = CreatePizza(type);

        pizza.Prepare();
        Pizza.Bake();
        Pizza.Cut();
        Pizza.Box();

        return pizza;
    }

    protected abstract Pizza CreatePizza(string type);
}