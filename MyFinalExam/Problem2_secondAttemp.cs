using System;
using System.Text;
using System.Text.RegularExpressions;

namespace Problem2_secondAttemp
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string pattern = @"^([$%])(?<tag>[A-Z][a-z]{2,})\1\:\s\[(\d+)\]\|\[(\d+)\]\|\[(\d+)\]\|$";
            Regex regEx = new Regex(pattern);
            for (int i = 0; i < n; i++)
            {
                string message = Console.ReadLine();
                MatchCollection collection = regEx.Matches(message);
                if (collection.Count == 0)
                {
                    Console.WriteLine("Valid message not found!");
                }
                else
                {
                    foreach (Match item in collection)
                    {
                        if (item.Success)
                        {
                            string tag = item.Groups["tag"].Value;
                            int ch1 = int.Parse(item.Groups[2].Value);
                            int ch2 = int.Parse(item.Groups[3].Value);
                            int ch3 = int.Parse(item.Groups[4].Value);
                            StringBuilder sb = new StringBuilder();
                            sb.Append((char)ch1);
                            sb.Append((char)ch2);
                            sb.Append((char)ch3);
                            Console.WriteLine($"{tag}: {sb.ToString()}");
                        }
                    }
                }
                
            }
        }
    }
}
