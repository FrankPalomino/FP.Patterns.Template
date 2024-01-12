namespace FP.Patterns.Template.Exercice2
{
    public class AmericanoMaker : CoffeBrewer
    {
        protected override void AddCondiments()
        {
            Console.WriteLine("Add Condiments for Americano Coffee");
        }

        protected override void BoilWatter()
        {
            Console.WriteLine("Boil Watter for Americano Coffee");
        }

        protected override void BrewGroundCoffee()
        {
            Console.WriteLine("Brew Ground Coffe for Americano Coffee");
        }

        protected override void PourInCup()
        {
            Console.WriteLine("Pour In Cup the Americano Coffee");
        }
    }
}
