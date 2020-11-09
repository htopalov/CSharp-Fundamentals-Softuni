using System;
using System.Collections.Generic;
using System.Linq;

namespace Loot
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> treasureChest = Console.ReadLine()
                                        .Split('|', StringSplitOptions.RemoveEmptyEntries)
                                        .ToList();
            string command = Console.ReadLine();
            while (command != "Yohoho!")
            {
                string[] commandArguments = command.Split().ToArray();
                string action = commandArguments[0];
                switch (action)
                {
                    case "Loot":
                        for (int i = 1; i < commandArguments.Length; i++)
                        {
                            if (!treasureChest.Contains(commandArguments[i]))
                            {
                                    treasureChest.Insert(0, commandArguments[i]);
                            }
                        }
                        break;
                    case "Drop":
                        int index = int.Parse(commandArguments[1]);
                        if(index<0)
                        {
                            break;
                        }
                        if (index >= 0 && index <= treasureChest.Count)
                        {
                            string currentTreasure = treasureChest[index];
                            treasureChest.RemoveAt(index);
                            treasureChest.Add(currentTreasure);
                        }
                        break;
                    case "Steal":
                        int count = int.Parse(commandArguments[1]);
                        List<string> stolenItems = new List<string>();
                        if(count <= treasureChest.Count)
                        {
                            for (int i = 0; i < count; i++)
                            {
                                stolenItems.Add(treasureChest[treasureChest.Count - 1]);
                                treasureChest.RemoveAt(treasureChest.Count - 1);
                            }
                            stolenItems.Reverse();
                        }
                        else if(count >=treasureChest.Count)
                        {
                            for (int j = 0; j < treasureChest.Count; j++)
                            {
                                stolenItems.Add(treasureChest[j]);
                            }
                            treasureChest.Clear();
                        }
                        
                        Console.WriteLine(string.Join(", ", stolenItems));
                        break;
                }
                command = Console.ReadLine();
            }
            int totalStringLength = 0;
            for (int i = 0; i < treasureChest.Count; i++)
            {
                totalStringLength += treasureChest[i].Length;
            }
            double averageGain = (double)totalStringLength / treasureChest.Count;
            if (treasureChest.Count > 0)
            {
                Console.WriteLine($"Average treasure gain: {averageGain:f2} pirate credits.");
            }
            else if (treasureChest.Count == 0)
            {
                Console.WriteLine("Failed treasure hunt.");
            }
        }
    }
}
