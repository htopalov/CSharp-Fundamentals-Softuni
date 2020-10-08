using System;
using System.Linq;

namespace Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int bestCounter = 0;
            int bestIndex = 0;
            for (int i = 0; i < input.Length; i++)
            {
                string currentNumber = input[i];
                int counter = 1;
                for (int j = i+1; j < input.Length; j++)
                {
                    if(currentNumber==input[j])
                    {
                        counter++;
                    }
                    else
                    {
                        break;
                    }
                }
                if(counter>bestCounter)
                {
                    bestCounter = counter;
                    bestIndex = i;
                }
            }
            for (int i = 0; i < bestCounter; i++)
            {
                Console.Write($"{input[bestIndex]} ");
            }
        }
    }
}
