using System;
using System.Collections.Generic;

namespace SoftUni_Parking
{
    class Program
    {
        static void Main(string[] args)
        {
            int commandsCount = int.Parse(Console.ReadLine());
            Dictionary<string, string> registry = new Dictionary<string, string>();
            for (int i = 0; i < commandsCount; i++)
            {
                string[] command = Console.ReadLine().Split();
                switch (command[0])
                {
                    case "register":
                        if (!registry.ContainsKey(command[1]))
                        {
                            registry.Add(command[1], command[2]);
                            Console.WriteLine($"{command[1]} registered {command[2]} successfully");
                        }
                        else
                        {
                            string existingPlate = string.Empty;
                            if (registry.TryGetValue(command[1], out existingPlate))
                            {
                                Console.WriteLine($"ERROR: already registered with plate number {existingPlate}");
                            }
                        }
                        break;
                    case "unregister":
                        if (registry.ContainsKey(command[1]))
                        {
                            Console.WriteLine($"{command[1]} unregistered successfully");
                            registry.Remove(command[1]);
                        }
                        else
                        {
                            Console.WriteLine($"ERROR: user {command[1]} not found");
                        }
                        break;
                }
            }
            foreach (var item in registry)
            {
                Console.WriteLine($"{item.Key} => {item.Value}");
            }
        }
    }
}
