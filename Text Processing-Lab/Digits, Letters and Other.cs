using System;

namespace Digits__Letters_and_Other
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsDigit(input[i]))
                {
                    Console.Write(input[i]);
                }
            }
            Console.WriteLine();
            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsLetter(input[i]))
                {
                    Console.Write(input[i]);
                }
            }
            Console.WriteLine();
            for (int i = 0; i < input.Length; i++)
            {
                if (!char.IsLetter(input[i]) && !char.IsDigit(input[i]))
                {
                    Console.Write(input[i]);
                }
            }

        }
    }
}
