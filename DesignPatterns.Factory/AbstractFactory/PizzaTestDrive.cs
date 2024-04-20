using DesignPatterns.Factory.AbstractFactory;

PizzaStore nyStore = new NYPizzaStore();
PizzaStore chicagoStore = new ChicagoPizzaStore();

var pizza = nyStore.OrderPizza("cheese");
Console.WriteLine($"Ethan ordered a {pizza} \n");

pizza = chicagoStore.OrderPizza("cheese");
Console.WriteLine($"Joel ordered a {pizza} \n");

pizza = nyStore.OrderPizza("veggie");
Console.WriteLine($"Ethan ordered a {pizza} \n");

pizza = chicagoStore.OrderPizza("veggie");
Console.WriteLine($"Joel ordered a {pizza} \n");