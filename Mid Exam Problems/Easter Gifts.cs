using System;
using System.Collections.Generic;
using System.Linq;

namespace Easter_Gifts
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> giftCollection = Console.ReadLine()
                                         .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                                         .ToList();
            string command = Console.ReadLine();
            while (command != "No Money")
            {
                string[] commandArguments = command
                                            .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                                            .ToArray();
                switch (commandArguments[0])
                {
                    case "OutOfStock":
                        for (int i = 0; i < giftCollection.Count; i++)
                        {
                            if (giftCollection.Contains(commandArguments[1]))
                            {
                                int index = giftCollection.IndexOf(commandArguments[1]);
                                giftCollection[index] = "None";
                            }
                        }
                        break;
                    case "Required":
                        if (int.Parse(commandArguments[2]) > 0 && int.Parse(commandArguments[2]) < giftCollection.Count)
                        {
                            giftCollection[int.Parse(commandArguments[2])] = commandArguments[1];
                        }
                        break;
                    case "JustInCase":
                        giftCollection[giftCollection.Count - 1] = commandArguments[1];
                        break;
                }
                command = Console.ReadLine();
            }
            foreach (string gift in giftCollection)
            {
                if (gift != "None")
                {
                    Console.Write(gift + " ");
                }
            }
        }
    }
}
