using DesignPatterns.StrategyPattern.Behaviors;
using DesignPatterns.StrategyPattern.Models.Ducks;

FlyNoWay flyNoWay = new();
MuteQuack muteQuack = new();

DecoyDuck decoyDuck = new(flyNoWay, muteQuack);

decoyDuck.display();
decoyDuck.performQuack();
decoyDuck.performFly();
decoyDuck.swim();

FlyNoWay cantFly = new();
Squeak squeak = new();

MallardDuck mallard = new();
RubberDuck rubberDuckie = new(cantFly, squeak);

mallard.performQuack();
rubberDuckie.performQuack();
mallard.setQuackBehavior(new FakeQuack());
mallard.performQuack();