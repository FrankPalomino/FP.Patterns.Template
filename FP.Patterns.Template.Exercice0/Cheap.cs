namespace FP.Patterns.Template
{
    public class Cheap : IPrimitive
    {
        public double Decorate(int amount)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            for (int i = 0; i < amount; i++)
                Console.WriteLine("Adding a cheap sticker");
            return 1.5 * amount;
        }

        public double Packing(int amount)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            for (int i = 0; i < amount; i++)
                Console.WriteLine("Put in a cheap bag");
            return 0.25 * amount;
        }
    }
}
