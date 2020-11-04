using System;
using System.Collections.Generic;
using System.Linq;

namespace Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                            .Split()
                            .Select(int.Parse)
                            .ToArray();
            List<int> greaterNumbers = new List<int>();
            List<int> finalNumbers = new List<int>(5);
            int total = 0;
            bool isGreater = true;
            for (int i = 0; i < numbers.Length; i++)
            {
                total += numbers[i];
            }

            double average =(double) total / numbers.Length;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > average)
                {
                    greaterNumbers.Add(numbers[i]);
                }
            }
            greaterNumbers.Sort();
            greaterNumbers.Reverse();
            for (int i = 0; i < numbers.Length; i++)
            {
                if (average == numbers[i])
                {
                    isGreater = false;
                }
            }
            if(!isGreater)
            {
                Console.WriteLine("No");
            }
            if (greaterNumbers.Count >= 5)
            {
                for (int i = 0; i <= 4; i++)
                {
                    finalNumbers.Add(greaterNumbers[i]);
                }
                Console.WriteLine(string.Join(' ', finalNumbers));
            }
            else
            {
                Console.WriteLine(string.Join(' ', greaterNumbers));
            }

        }
    }
}
