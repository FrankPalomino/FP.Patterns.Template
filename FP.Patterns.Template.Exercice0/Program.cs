using FP.Patterns.Template;

int amount = 0;
string type = "";
IPrimitive primitive = null;
double total = 0;

Console.WriteLine("1-Barato, 2-Normal");
type = Console.ReadLine();
if (type == "1")
    primitive = new Cheap();
else
    primitive = new Normal();

Console.WriteLine("How many toys?");
amount = int.Parse(Console.ReadLine());

Algorithm production = new Algorithm();

total = production.TemplateMethod(primitive, amount);

Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine("Total: {0}", total);