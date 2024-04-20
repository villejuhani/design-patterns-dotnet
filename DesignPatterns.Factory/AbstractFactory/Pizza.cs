using System.Text;
using DesignPatterns.Factory.AbstractFactory.PizzaIngredients.Interfaces;

namespace DesignPatterns.Factory.AbstractFactory;

public abstract class Pizza
{
    public string Name { get; set; }
    protected IDough? Dough;
    protected ISauce? Sauce;
    protected ICheese? Cheese;
    protected IVeggies[]? Veggies;

    public abstract void Prepare();
    public static void Bake()
    {
        Console.WriteLine("Baking for 25 minutes at 200");
    }

    public static void Cut()
    {
        Console.WriteLine("Cutting the pizza");
    }

    public static void Box()
    {
        Console.WriteLine("Placing the pizza in a box");
    }

    public override string ToString()
    {
        var result = new StringBuilder();
        result.Append($"\n-----------------{Name}-----------------\n");
        if (Dough != null)
            result.Append(Dough + "\n");
        if (Sauce != null)
            result.Append(Sauce + "\n");
        if (Cheese != null)
            result.Append(Cheese + "\n");
        if (Veggies != null)
        {
            for (int i = 0; i < Veggies.Length; i++) {
                result.Append(Veggies[i]);
                if (i < Veggies.Length - 1) {
                    result.Append(", ");
                }
            }
        }
        
        return result.ToString();
    }
}