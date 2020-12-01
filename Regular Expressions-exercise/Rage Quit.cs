using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Rage_Quit
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"([A-Za-z\W_]+)(\d+)";
            Regex regex = new Regex(pattern);
            MatchCollection matchCollection = regex.Matches(input);
            StringBuilder finalString = new StringBuilder();
            foreach (Match item in matchCollection)
            {
                if (item.Success)
                {
                    string currentString = item.Groups[1].Value.ToUpper();
                    int digit = int.Parse(item.Groups[2].Value);
                    for (int i = 0; i < digit; i++)
                    {
                        finalString.Append(currentString);
                    }

                }
            }
            char[] symbolsCount = finalString.ToString().Distinct().ToArray();
            Console.WriteLine($"Unique symbols used: {symbolsCount.Length}");
            Console.WriteLine(finalString.ToString());
        }
    }
}
