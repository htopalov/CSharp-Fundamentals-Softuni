using System;

namespace Multiplication_table_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int times = int.Parse(Console.ReadLine());
            do
            {
                Console.WriteLine($"{number} X {times} = {number * times}");
                times++;
            } while (times <= 10);

        }
    }
}
