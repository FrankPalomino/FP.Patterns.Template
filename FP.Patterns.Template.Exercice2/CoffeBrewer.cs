namespace FP.Patterns.Template.Exercice2
{
    public abstract class CoffeBrewer
    {
        public void BrewCoffee()
        {
            BoilWatter();
            BrewGroundCoffee();
            PourInCup();
            AddCondiments();
        }
        protected abstract void BoilWatter();
        protected abstract void BrewGroundCoffee();
        protected abstract void PourInCup();
        protected abstract void AddCondiments();
    }
}
