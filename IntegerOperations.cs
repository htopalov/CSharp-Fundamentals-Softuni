using System;

namespace IntegerOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            int number3 = int.Parse(Console.ReadLine());
            int number4 = int.Parse(Console.ReadLine());
            number1 += number2;
            number1 /= number3;
            number1 *= number4;
            Console.WriteLine(number1);
        }
    }
}
