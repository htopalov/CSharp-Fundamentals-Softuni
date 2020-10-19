using System;
using System.Collections.Generic;
using System.Linq;

namespace Merging_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input1 = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            List<int> input2 = Console.ReadLine()
                 .Split()
                 .Select(int.Parse)
                 .ToList();

            List<int> result = new List<int>();

            for (int i = 0; i < Math.Min(input1.Count, input2.Count); i++)
            {
                result.Add(input1[i]);
                result.Add(input2[i]);
            }
            for (int i = Math.Min(input1.Count, input2.Count); i < Math.Max(input1.Count, input2.Count); i++)
            {
                if(i>=input1.Count)
                {
                    result.Add(input2[i]);
                }
                else
                {
                    result.Add(input1[i]);
                }
            }
            Console.WriteLine(string.Join(" ", result));
         }
    }
}

