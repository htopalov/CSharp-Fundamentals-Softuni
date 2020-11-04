using System;
using System.Collections.Generic;
using System.Linq;

namespace Array_Modifier
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] integersList = Console.ReadLine()
                                    .Split()
                                    .Select(int.Parse)
                                    .ToArray();
            string command = Console.ReadLine();
            while(command!="end")
            {
                string[] commandArguments = command.Split();
                string action = commandArguments[0];
                
                int temp = 0;
                switch (action)
                {
                    case "swap":
                        int firstIndexSwap = int.Parse(commandArguments[1]);
                        int secondIndexSwap = int.Parse(commandArguments[2]);
                        temp = integersList[firstIndexSwap];
                        integersList[firstIndexSwap] = integersList[secondIndexSwap];
                        integersList[secondIndexSwap] = temp;
                        break;
                    case "multiply":
                        int firstIndexMulti = int.Parse(commandArguments[1]);
                        int secondIndexMulti = int.Parse(commandArguments[2]);
                        temp = integersList[firstIndexMulti] * integersList[secondIndexMulti];
                        integersList[firstIndexMulti] = temp;
                        break;
                    case "decrease":
                        for (int i = 0; i < integersList.Length; i++)
                        {
                            integersList[i] -= 1;
                        }
                        break;
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(", ",integersList));
        }
    }
}
