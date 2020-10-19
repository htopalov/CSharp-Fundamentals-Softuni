using System;
using System.Collections.Generic;
using System.Linq;

namespace Append_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> originalList = Console.ReadLine()
                                                .Split("|")
                                                .ToList();

            originalList.Reverse();

            List<string> result = new List<string>();

            foreach (string item in originalList)
            {
                string[] numbers = item.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                foreach (string numbersToAdd in numbers)
                {
                    result.Add(numbersToAdd);
                }
            }
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
