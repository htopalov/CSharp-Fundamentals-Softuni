using System;
using System.Collections.Generic;
using System.Linq;

namespace Inventory
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> inventory = Console.ReadLine()
                                     .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                                     .ToList();
            string command = Console.ReadLine();
            while (command != "Craft!")
            {
                string[] commandArguments = command.Split(" - ")
                                                   .ToArray();
                string action = commandArguments[0];
                string item = commandArguments[1];
                switch (action)
                {
                    case "Collect":
                        if (!inventory.Contains(item))
                        {
                            inventory.Add(item);
                        }
                        break;
                    case "Drop":
                        if (inventory.Contains(item))
                        {
                            inventory.Remove(item);
                        }
                        break;
                    case "Combine Items":
                        string[] splitSecondPart = commandArguments[1].Split(":");
                        string oldItem = splitSecondPart[0];
                        string newItem = splitSecondPart[1];
                        if (inventory.Contains(oldItem))
                        {
                            int indexOfItem = inventory.IndexOf(oldItem);
                            inventory.Insert(indexOfItem + 1, newItem);
                        }
                        break;
                    case "Renew":
                        if(inventory.Contains(item))
                        {
                            inventory.Remove(item);
                            inventory.Add(item);
                        }
                        break;
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(", ",inventory));
        }
    }
}
