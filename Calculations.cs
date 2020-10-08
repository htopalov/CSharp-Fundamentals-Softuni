using System;

namespace Calculations
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            switch(command)
            {
                case "add": Add(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine())); break;
                case "multiply": Multiply(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine())); break;
                case "substract": Subtract(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine())); break;
                case "divide": Divide(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine())); break;
            }
        }
        static void Add(int number1, int number2)
        {
            Console.WriteLine(number1+number2);
        }
        static void Multiply(int number1, int number2)
        {
            Console.WriteLine(number1*number2);
        }
        static void Subtract(int number1, int number2)
        {
            Console.WriteLine(number1-number2);
        }
        static void Divide(int number1, int number2)
        {
            Console.WriteLine(number1/number2);
        }
    }
}
