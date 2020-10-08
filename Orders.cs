using System;

namespace Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            OrderCalculator(Console.ReadLine(), int.Parse(Console.ReadLine()));
        }
        static void OrderCalculator(string product, int quantity)
        {
            double productPrice = 0;
            switch(product)
            {
                case "coffee": productPrice = 1.5*quantity; break;
                case "water": productPrice = 1.0*quantity; break;
                case "coke": productPrice = 1.4*quantity; break;
                case "snacks": productPrice = 2.0*quantity; break;
            }
            Console.WriteLine($"{productPrice:f2}");
        }
    }
}
