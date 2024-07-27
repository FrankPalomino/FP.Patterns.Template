
using FP.Patterns.Template.Exercice4;

OnlineOrderProcessor onlineShopping = new();
InStorePickupOrderProcessor inStoreShopping = new();

onlineShopping.MakeOrder();
Console.WriteLine("------------------");
inStoreShopping.MakeOrder();