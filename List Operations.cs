using System;
using System.Collections.Generic;
using System.Linq;

namespace List_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            string command = Console.ReadLine();
            while (command != "End")
            {
                string[] commandArr = command.Split().ToArray();
                switch (commandArr[0])
                {
                    case "Add":
                        numbers.Add(int.Parse(commandArr[1]));
                        break;

                    case "Insert":
                        if (int.Parse(commandArr[2]) <= numbers.Count && int.Parse(commandArr[2]) >= 0)
                        {
                            numbers.Insert(int.Parse(commandArr[2]), int.Parse(commandArr[1]));
                        }
                        else
                        {
                            Console.WriteLine("Invalid index");
                        }
                        break;

                    case "Remove":
                        if (int.Parse(commandArr[1]) <= numbers.Count && int.Parse(commandArr[1]) >= 0)
                        {
                            numbers.RemoveAt(int.Parse(commandArr[1]));
                        }
                        else
                        {
                            Console.WriteLine("Invalid index");
                        }
                        break;

                    case "Shift":
                        if (commandArr[1] == "left")
                        {
                            for (int i = 0; i < int.Parse(commandArr[2]); i++)
                            {
                                int firstElement = numbers[0];
                                for (int j = 0; j < numbers.Count - 1; j++)
                                {
                                    numbers[j] = numbers[j + 1];
                                }
                                numbers[numbers.Count - 1] = firstElement;
                            }
                        }
                        else if (commandArr[1] == "right")
                        {
                            for (int i = 0; i < int.Parse(commandArr[2]); i++)
                            {
                                int lastElement = numbers[numbers.Count - 1];
                                for (int j = numbers.Count - 1; j > 0; j--)
                                {
                                    numbers[j] = numbers[j - 1];
                                }
                                numbers[0] = lastElement;

                            }
                        }
                        break;
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
