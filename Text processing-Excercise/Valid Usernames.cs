using System;
using System.Linq;

namespace Valid_Usernames
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(", ");
            foreach (var ch in input)
            {
                var current = ch;
                if (isValid(current))
                {
                    Console.WriteLine(current);
                }

            }
        }

        private static bool isValid(string current)
        {
            return current.Length >= 3 && current.Length <= 16 && current.All(c => char.IsLetterOrDigit(c) || current.Contains('-') || current.Contains('_'));
        }
    }
}
