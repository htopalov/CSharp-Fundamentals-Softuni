using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Mirror_words
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"([\#|\@])(?<firstWord>[A-Za-z]{3,})\1{2}(?<secondWord>[A-Za-z]{3,})\1";
            string input = Console.ReadLine();
            Regex regEx = new Regex(pattern);
            MatchCollection matchCollection = regEx.Matches(input);
            List<string> mirrorWords = new List<string>();
            foreach (Match item in matchCollection)
            {
                if (item.Success)
                {

                    string firstWord = item.Groups["firstWord"].Value;
                    string secondWord = item.Groups["secondWord"].Value;
                    string reversed = string.Empty;
                    for (int i = secondWord.Length - 1; i >= 0; i--)
                    {
                        reversed += secondWord[i];
                    }
                    if (firstWord == reversed)
                    {
                        mirrorWords.Add(firstWord + " <=> " + secondWord);
                    }
                }
            }
            if (matchCollection.Count > 0)
            {
                Console.WriteLine($"{matchCollection.Count} word pairs found!");
            }
            else
            {
                Console.WriteLine("No word pairs found!");
            }
            if (mirrorWords.Count == 0)
            {
                Console.WriteLine("No mirror words!");
            }
            else
            {
                Console.WriteLine("The mirror words are:");
                Console.Write(string.Join(", ",mirrorWords));
            }
        }
    }
}
