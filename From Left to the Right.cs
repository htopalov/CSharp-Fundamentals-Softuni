using System;

namespace From_Left_to_the_Right
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            long sum = 0;
            long sum2 = 0;
            for (int i = 0; i < count; i++)
            {
                string input = Console.ReadLine();
                string[] number1 = input.Split(' ');
                long firstNumber = long.Parse(number1[0]);
                long secondNumber = long.Parse(number1[1]);
                if(firstNumber>secondNumber)
                {
                    while(firstNumber !=0)
                    {
                        sum += firstNumber%10;
                        firstNumber /= 10;
                    }
                    Console.WriteLine(Math.Abs(sum));
                    sum = 0;
                }
                else
                {
                    while (secondNumber != 0)
                    {
                        sum2 += secondNumber % 10;
                        secondNumber /= 10;
                    }
                    Console.WriteLine(Math.Abs(sum2));
                    sum2 = 0;
                }
            }
        }
    }
}
