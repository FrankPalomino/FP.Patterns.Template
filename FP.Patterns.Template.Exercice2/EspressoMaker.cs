namespace FP.Patterns.Template.Exercice2
{
    public class EspressoMaker : CoffeBrewer
    {
        protected override void AddCondiments()
        {
            Console.WriteLine("Add Condiments for Espresso Coffee");
        }

        protected override void BoilWatter()
        {
            Console.WriteLine("Boil Watter for Espresso Coffee");
        }

        protected override void BrewGroundCoffee()
        {
            Console.WriteLine("Brew Ground Coffe for Espresso Coffee");
        }

        protected override void PourInCup()
        {
            Console.WriteLine("Pour In Cup the Espresso Coffee");
        }
    }
}
