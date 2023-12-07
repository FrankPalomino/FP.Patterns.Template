namespace FP.Patterns.Template
{
    public class Normal : IPrimitive
    {
        public double Decorate(int amount)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            for (int i = 0; i < amount; i++)
                Console.WriteLine("Adding a normal sticker");
            return 2.5 * amount;
        }

        public double Packing(int amount)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            for (int i = 0; i < amount; i++)
                Console.WriteLine("Put in a normal box");
            return 0.5 * amount;
        }
    }
}
