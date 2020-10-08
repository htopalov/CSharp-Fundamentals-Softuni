using System;
using System.Linq;

namespace Sum_Even_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int[] array = input.Split().Select(int.Parse).ToArray();
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if(array[i] %2==0)
                {
                    sum += array[i];
                }
            }
            Console.WriteLine(sum);
        }
    }
}
