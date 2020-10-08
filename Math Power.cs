using System;

namespace Math_Power
{
    class Program
    {
        static void Main(string[] args)
        {
            double result = MathPower(double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()));
            Console.WriteLine(result);
        }
        static double MathPower(double number, double power)
        {
            return Math.Pow(number, power);
        }
    }
}
