namespace DesignPatterns.Factory.AbstractFactory.PizzaIngredients.Interfaces;

public interface IPizzaIngredientFactory
{
    public IDough CreateDough();
    public ISauce CreateSauce();
    public ICheese CreateCheese();
    public IVeggies[] CreateVeggies();
}