using System;
using System.Collections.Generic;

namespace List_of_Products
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            List<string> products = new List<string>();
            for (int i = 0; i < number; i++)
            {
                products.Add(Console.ReadLine());
            }
            products.Sort();
            for (int i = 0; i < number; i++)
            {
                Console.WriteLine($"{i+1}.{products[i]}");
            }
        }
    }
}
