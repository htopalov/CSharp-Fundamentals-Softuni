using System;
using System.Collections.Generic;
using System.Linq;

namespace Shopping_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> groceries = Console.ReadLine().Split('!').ToList();
            while (true)
            {
                string[] command = Console.ReadLine().Split().ToArray();
                string action = command[0];
                if (command[0] == "Go")
                {
                    break;
                }
                switch (action)
                {
                    case "Urgent":
                        if (!groceries.Contains(command[1]))
                        {
                            groceries.Insert(0, command[1]);
                        }
                        break;
                    case "Unnecessary":
                            groceries.Remove(command[1]);
                        break;
                    case "Correct":
                        if (groceries.Contains(command[1]))
                        {
                            int index = groceries.IndexOf(command[1]);
                            groceries.RemoveAt(index);
                            groceries.Insert(index, command[2]);
                        }
                        break;
                    case "Rearrange":
                        if (groceries.Contains(command[1]))
                        {
                            groceries.Remove(command[1]);
                            groceries.Add(command[1]);
                        }
                        break;
                }
            }
            Console.WriteLine(string.Join(", ", groceries));
        }
    }
}
