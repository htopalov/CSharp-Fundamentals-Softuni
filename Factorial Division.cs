using System;

namespace Factorial_Division
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            double fact1 = FactorialFunction(number1);
            double fact2 = FactorialFunction(number2);
            Console.WriteLine($"{fact1/fact2:f2}");
        }
        static double FactorialFunction(int number)
        {
            double result = 1;
            while (number != 1)
            {
                result = result * number;
                number = number - 1;
            }
            return result;
        }
    }
}
