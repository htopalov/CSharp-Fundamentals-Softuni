﻿using System;

namespace Multiplication_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int integerInput = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{integerInput} X {i} = {integerInput*i}");
            }
        }
    }
}
