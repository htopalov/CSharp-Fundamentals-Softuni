using System;
using System.Linq;

namespace Rounding_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //double[] array = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            string input = Console.ReadLine();
            string[] array = input.Split();
            double[] array2 = new double[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                array2[i] = double.Parse(array[i]);
               if (array2[i] == 0)
                {
                    array2[i] = 0;
                }
                Console.WriteLine($"{array2[i]} => {Math.Round(array2[i], MidpointRounding.AwayFromZero)}");
            }
        }
    }
}
