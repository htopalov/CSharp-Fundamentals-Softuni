using System;
using System.Text;
using System.Text.RegularExpressions;

namespace Destination_Mapper
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(\=|\/)([A-Z][A-Za-z]{2,})\1";
            string input = Console.ReadLine();
            Regex regEx = new Regex(pattern);
            MatchCollection matchCollection = regEx.Matches(input);
            int points = 0;
            StringBuilder sb = new StringBuilder();
            sb.Append("Destinations: ");
            foreach (Match item in matchCollection)
            {
                points += item.Groups[2].Value.Length;
                sb.Append(item.Groups[2].Value + ", ");
            }
            if (sb.Length>14)
            {
                sb.Remove(sb.Length - 2, 2);
            }
            Console.WriteLine(sb.ToString());
            Console.WriteLine($"Travel Points: {points}");
        }
    }
}
