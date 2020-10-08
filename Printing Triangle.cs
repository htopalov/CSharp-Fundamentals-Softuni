using System;

namespace Printing_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            TriangleFunction(int.Parse(Console.ReadLine()));
        }
        static void TriangleFunction(int number)
        {
            for (int i = 1; i <= number; i++)
            {
                PrintLine(1, i);
            }
            for (int i = number-1; i >= 1; i--)
            {
                PrintLine(1, i);
            }
        }
        static void PrintLine(int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                Console.Write(i +" ");
            }
            Console.WriteLine();
        }
    }
}
