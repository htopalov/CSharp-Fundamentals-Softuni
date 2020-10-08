using System;

namespace ReverseNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] array1 = new int[n];
            for (int i = 0; i < n; i++)
            {
                array1[i] = int.Parse(Console.ReadLine());
            }
            Array.Reverse(array1);
            for (int i = 0; i < array1.Length; i++)
            {
                Console.Write($"{array1[i]} ");
            }
        }
    }
}
