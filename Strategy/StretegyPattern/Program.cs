using System;

namespace StretegyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new Context(new CarStrategy());
            context.Run();
            context.Strategy = new MotoStrategy();
            context.Run();

            Console.ReadLine();
        }
    }
}
