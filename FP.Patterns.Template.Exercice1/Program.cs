using FP.Patterns.Template.Exercice1;

Console.WriteLine("Select your product");
Console.WriteLine("1. Electornic | 2. Home | 3. Toy");
var productType = Console.ReadLine();
IProduct product;
switch (productType)
{
    case "1":
        product = new ElectronicProduct();
        break;
    case "2":
        product = new HomeProduct();
        break;
    case "3":
        product = new ToyProduct();
        break;
    default:
        throw new Exception("Product not supported");
}

product.Search();
product.Sort();
