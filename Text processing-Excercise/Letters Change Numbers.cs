using System;

namespace Letters_Change_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            double result = 0;
            string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            for (int i = 0; i < input.Length; i++)
            {
                string current = input[i];
                char firstLetter = current[0];
                char lastLetter = current[current.Length - 1];
                double number = double.Parse(current.Substring(1, current.Length - 2));
                int firstLetterIndex = alphabet.IndexOf(char.ToUpper(firstLetter));
                int lastLetterIndex = alphabet.IndexOf(char.ToUpper(lastLetter));

                if ((int)firstLetter >=65 && (int)firstLetter<=90)
                {
                    number = number / (firstLetterIndex + 1);
                }
                else
                {
                    number = number * (firstLetterIndex + 1);
                }
                if ((int)lastLetter >=65 && (int)lastLetter<=90)
                {
                    number = number - (lastLetterIndex + 1);
                }
                else
                {
                    number = number + (lastLetterIndex + 1);
                }
                result += number;
            }
            Console.WriteLine($"{result:f2}");
        }
    }
}
