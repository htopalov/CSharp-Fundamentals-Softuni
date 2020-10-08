using System;

namespace Multiply_Evens_by_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = Math.Abs(int.Parse(Console.ReadLine()));
            int endResult = GetMultipleOfEvenAndOdds(input);
            Console.WriteLine(endResult);
        }
        static int GetMultipleOfEvenAndOdds(int sum)
        {
            int multiplySums = GetSumOfEvenDigits(sum) * GetSumOfOddDigits(sum);
            return multiplySums;
        }
        static int GetSumOfEvenDigits(int number)
        {
            int sumEven = 0;
            while(number!=0)
            {
                int digit = number % 10;
                if(digit%2==0)
                {
                    sumEven += digit;
                }
                number /= 10;
            }
            return sumEven;
        }
        static int GetSumOfOddDigits(int number)
        {
            int sumOdd = 0;
            while (number != 0)
            {
                int digit = number % 10;
                if (digit % 2 != 0)
                {
                    sumOdd += digit;
                }
                number /= 10;
            }
            return sumOdd;
        }
    }
}
