using System;

namespace StatePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var customerContext = new CustomerContext();
            Console.WriteLine(customerContext.GetState()); // estado inicial
            Console.WriteLine();

            customerContext.Request(100); // asigna saldo
            Console.WriteLine(customerContext.GetState()); // el estado cambia
            Console.WriteLine();

            customerContext.Request(50);
            Console.WriteLine(customerContext.GetState());
            Console.WriteLine();

            customerContext.Request(100);
            Console.WriteLine(customerContext.GetState());
            Console.WriteLine();

            customerContext.Request(50);
            Console.WriteLine(customerContext.GetState());
            Console.WriteLine();

            customerContext.Request(50);
            Console.WriteLine(customerContext.GetState());

            Console.ReadLine();
        }
    }
}
