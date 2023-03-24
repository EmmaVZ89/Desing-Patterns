using System;

namespace DependencyInjection
{
    class Program
    {
        static void Main(string[] args)
        {
            var beer = new Beer("Pikantus", "Erdinger");
            var drinkWitBeer = new DrinkWithBeer(10, 1, beer);
            drinkWitBeer.Build();
            Console.ReadKey();
        }
    }
}
