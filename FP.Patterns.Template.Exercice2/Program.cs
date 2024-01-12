using FP.Patterns.Template.Exercice2;

CoffeBrewer americano = new AmericanoMaker();
CoffeBrewer espresso = new EspressoMaker();

americano.BrewCoffee();
Console.WriteLine("-------------------");
espresso.BrewCoffee();