using System;

namespace Math_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            char operation = char.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int calc =  Calculation(firstNumber, operation, secondNumber);
            Console.WriteLine(calc);
        }
        static int Calculation(int num1, char sign, int num2)
        {
            int result = 0;
            switch(sign)
            {
                case '/': result = num1 / num2; break;
                case '*': result = num1 * num2; break;
                case '+': result = num1 + num2; break;
                case '-': result = Math.Abs(num1 - num2); break;
            }
            return result;
        }
    }
}
