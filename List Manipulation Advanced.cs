using System;
using System.Collections.Generic;
using System.Linq;

namespace List_Manipulation_Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            bool isChanged = false;
            string command = string.Empty;
            while (command != "end")
            {
                command = Console.ReadLine().ToLower();
                List<string> commandList = command.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();
                switch (commandList[0])
                {
                    case "add":
                        numbers.Add(int.Parse(commandList[1]));
                        isChanged = true;
                        break;

                    case "remove":
                        numbers.Remove(int.Parse(commandList[1]));
                        isChanged = true;
                        break;

                    case "removeat":
                        numbers.RemoveAt(int.Parse(commandList[1]));
                        isChanged = true;
                        break;

                    case "insert":
                        numbers.Insert(int.Parse(commandList[2]), int.Parse(commandList[1]));
                        isChanged = true;
                        break;

                    case "contains":

                        Console.WriteLine(numbers.Contains(int.Parse(commandList[1])) ? "Yes" : "No such number");
                        break;

                    case "printeven":
                        Console.WriteLine(string.Join(' ', numbers.Where(n => n % 2 == 0)));
                        break;

                    case "printodd":
                        Console.WriteLine(string.Join(' ', numbers.Where(n => n % 2 != 0)));
                        break;

                    case "getsum":
                        Console.WriteLine(numbers.Sum());
                        break;

                    case "filter":
                        if (commandList[1] == "<")
                        {
                            Console.WriteLine(string.Join(' ', numbers.Where(n=> n< int.Parse(commandList[2]))));
                        }
                        else if (commandList[1] == ">")
                        {
                            Console.WriteLine(string.Join(' ', numbers.Where(n => n > int.Parse(commandList[2]))));
                        }
                        else if (commandList[1] == ">=")
                        {
                            Console.WriteLine(string.Join(' ', numbers.Where(n => n >= int.Parse(commandList[2]))));
                        }
                        else if (commandList[1] == "<=")
                        {
                            Console.WriteLine(string.Join(' ', numbers.Where(n => n <= int.Parse(commandList[2]))));
                        }
                        break;
                }
            }
            if (isChanged)
            {
                Console.WriteLine(string.Join(' ', numbers));
            }
        }
    }
}
