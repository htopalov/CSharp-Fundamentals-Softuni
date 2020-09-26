using System;

namespace Floating_Equality
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal precision = 0.000001M;
            decimal number1 = decimal.Parse(Console.ReadLine());
            decimal number2 = decimal.Parse(Console.ReadLine());
            decimal result = number1 - number2;
            bool isPrecise;
            if(Math.Abs(result)>=precision)
            {
                isPrecise = false;
                Console.WriteLine(isPrecise);
            }
            else
            {
                isPrecise = true;
                Console.WriteLine(isPrecise);
            }
        }
    }
}
