namespace FP.Patterns.Template.Exercice4
{
    public class OnlineOrderProcessor : OrderProcessor
    {
        public override void LookForItem()
        {
            Console.WriteLine("Looking item in all the web");
        }

        public override void PackageItem()
        {
            Console.WriteLine("Item is sending to your home");
        }

        public override void PayItem()
        {
            Console.WriteLine("Item paid with credit card");
        }

        public override void SelectItem()
        {
            Console.WriteLine("Putting item in the virtual cart");
        }
    }
}
