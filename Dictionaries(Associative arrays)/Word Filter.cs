﻿using System;
using System.Linq;

namespace Word_Filter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split().Where(n => n.Length % 2 == 0).ToArray();
            foreach (string word in words)
            {
                Console.WriteLine(word);
            }
        }
    }
}
