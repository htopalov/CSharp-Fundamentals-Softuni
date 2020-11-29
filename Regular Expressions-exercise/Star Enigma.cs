using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Star_Enigma
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputCount = int.Parse(Console.ReadLine());
            string pattern = @"@(?<planet>[A-Z][a-z]+)([^@\-!:>])*:(?<population>\d+)([^@\-!:>])*!(?<type>[A-Z])([^@\-!:>])*!->(?<soldiers>\d+)";
            List<string> attackPlanets = new List<string>();
            List<string> destroyedPlanets = new List<string>();
            string decrypted = string.Empty;
            int count = 0;
            for (int i = 0; i < inputCount; i++)
            {
                string input = Console.ReadLine();
                foreach (var item in input.ToLower())
                 {
                     if (item == 's' || item == 't' || item == 'a' || item == 'r')
                     {
                         count++;
                     }
                 }
                foreach (var item in input)
                {
                    char currentChar = (char)(item - count);
                    decrypted += currentChar;
                }
                Regex regex = new Regex(pattern);
                var match = regex.Match(decrypted);
                if (match.Success)
                {
                    if (match.Groups["type"].Value == "A")
                    {
                        attackPlanets.Add(match.Groups["planet"].Value.ToString());
                    }
                    else if (match.Groups["type"].Value == "D")
                    {
                        destroyedPlanets.Add(match.Groups["planet"].Value.ToString());
                    }
                }
                decrypted = string.Empty;
                count = 0;
            }
            Console.WriteLine($"Attacked planets: {attackPlanets.Count}");
            foreach (var item in attackPlanets.OrderBy(x => x))
            {
                Console.WriteLine($"-> {item}");
            }
            Console.WriteLine($"Destroyed planets: {destroyedPlanets.Count}");
            foreach (var item in destroyedPlanets.OrderBy(x => x))
            {
                Console.WriteLine($"-> {item}");
            }
        }
    }
}
