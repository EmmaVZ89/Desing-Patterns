using System;

namespace BuilderPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new PreparedAlcoholicDrinkConcreteBuilder();
            var barmanDirector = new BarmanDirector(builder);

            barmanDirector.PreparedMargarita();

            var preparedDrink = builder.GetPreparedDrink();

            Console.WriteLine(preparedDrink.Result);

            Console.ReadLine();
        }
    }
}
