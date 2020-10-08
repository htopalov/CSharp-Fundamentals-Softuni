using System;
using System.Linq;

namespace Magic_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputArr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int inputSum = int.Parse(Console.ReadLine());

            for (int i = 0; i < inputArr.Length; i++)
            {
                int currentNumber = inputArr[i];
                for (int j = i+1; j < inputArr.Length; j++)
                {
                    int currentNumber2 = inputArr[j];
                    if(inputSum == currentNumber+currentNumber2)
                    {
                        Console.WriteLine($"{currentNumber} {currentNumber2}");
                    }
                }
            }
        }
    }
}
