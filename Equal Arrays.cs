using System;
using System.Linq;

namespace Equal_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] array2 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int sum = 0;
            int count = 0;
            for (int i = 0; i < array1.Length; i++)
            {
                    if(array1[i] == array2[i])
                    {
                        sum += array1[i];
                    count++;
                    }
                    else
                    {
                        Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
                        break;
                    }
            }
            if (count == array1.Length)
            {
                Console.WriteLine($"Arrays are identical. Sum: {sum}");
            }
        }
    }
}
