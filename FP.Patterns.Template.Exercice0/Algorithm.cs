namespace FP.Patterns.Template
{
    public class Algorithm
    {
        public double TemplateMethod(IPrimitive type, int amount)
        {
            double total = 0;
            total +=  MakeToy(amount);
            total += type.Decorate(amount);

            Calidad();

            total += type.Packing(amount);

            return total;
        }

        private double MakeToy(int amount)
        {
            Console.WriteLine("Making {0} toys", amount);
            return 16.50 * amount;
        }

        private void Calidad()
        {
            Console.WriteLine("Quality control");
        }
    }
}
