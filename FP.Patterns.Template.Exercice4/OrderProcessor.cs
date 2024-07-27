namespace FP.Patterns.Template.Exercice4
{
    public abstract class OrderProcessor
    {
        public void MakeOrder()
        {
            LookForItem();
            SelectItem();
            PayItem();
            PackageItem();
        }
        public abstract void LookForItem();
        public abstract void SelectItem();
        public abstract void PayItem();
        public abstract void PackageItem();
    }
}
