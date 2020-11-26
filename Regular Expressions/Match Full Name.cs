﻿using System;
using System.Text.RegularExpressions;

namespace Match_Full_Name
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\b[A-Z][a-z]+ [A-Z][a-z]+\b";
            string text = Console.ReadLine();
            var match = Regex.Matches(text, pattern);
            Console.WriteLine(string.Join(" ", match));
        }
    }
}
