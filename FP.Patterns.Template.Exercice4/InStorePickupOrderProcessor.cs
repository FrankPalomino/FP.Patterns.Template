namespace FP.Patterns.Template.Exercice4
{
    public class InStorePickupOrderProcessor : OrderProcessor
    {
        public override void LookForItem()
        {
            Console.WriteLine("Looking for in Store items");
        }

        public override void PackageItem()
        {
            Console.WriteLine("Putting item in a bag");
        }

        public override void PayItem()
        {
            Console.WriteLine("Item paid in cash");
        }

        public override void SelectItem()
        {
            Console.WriteLine("Select item available in the store");
        }
    }
}
