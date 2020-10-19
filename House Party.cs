using System;
using System.Collections.Generic;
using System.Linq;

namespace House_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            List<string> names = new List<string>();
            for (int i = 0; i < number; i++)
            {
                string input = Console.ReadLine();
                string[] inputArgs = input.Split();
                bool isInList = names.Contains(inputArgs[0]);
                switch (inputArgs.Length)
                {
                    //3 commands means ADD, 4 means REMOVE
                    case 3:
                        if (isInList)
                        {
                            Console.WriteLine($"{inputArgs[0]} is already in the list!");
                        }
                        else
                        {
                            names.Add(inputArgs[0]);
                        }
                        break;
                    case 4:
                        if (isInList)
                        {
                            names.Remove(inputArgs[0]);
                        }
                        else
                        {
                            Console.WriteLine($"{inputArgs[0]} is not in the list!");
                        }
                        break;
                }
            }
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
