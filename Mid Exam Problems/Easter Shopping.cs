using System;
using System.Collections.Generic;
using System.Linq;

namespace Easter_Shopping
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> shopsList = Console.ReadLine()
                                        .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                                        .ToList();
            int numberOfCommands = int.Parse(Console.ReadLine());
            int count = 0;
            while(count != numberOfCommands)
            {
                string[] command = Console.ReadLine()
                                      .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                                      .ToArray();
                switch(command[0])
                {
                    case "Include":
                        shopsList.Add(command[1]);
                        break;
                    case "Visit":
                        if(!(int.Parse(command[2]) > shopsList.Count))
                        {
                            if(command[1] == "first")
                            {
                                shopsList.RemoveRange(0, int.Parse(command[2]));
                            }
                            else
                            {
                                int countLocal = 0;
                                while(countLocal!= int.Parse(command[2]))
                                {
                                    shopsList.RemoveAt(shopsList.Count - 1);
                                    countLocal++;
                                }      
                            }
                        }
                        break;
                    case "Prefer":
                        if(int.Parse(command[1]) >=0 && int.Parse(command[1])<shopsList.Count &&
                            int.Parse(command[2]) >= 0 && int.Parse(command[2])<shopsList.Count)
                        { 
                            string temp = shopsList[int.Parse(command[1])];
                            shopsList[int.Parse(command[1])] = shopsList[int.Parse(command[2])];
                            shopsList[int.Parse(command[2])] = temp;
                        }
                        break;
                    case "Place":
                        int shopIndexToInsert = int.Parse(command[2]) + 1;
                        if(shopIndexToInsert>0 && shopIndexToInsert<shopsList.Count)
                        {
                            shopsList.Insert(shopIndexToInsert, command[1]);
                        }
                        break;
                }
                count++;
            }
            Console.WriteLine("Shops left:");
            Console.WriteLine(string.Join(' ', shopsList));

        }
    }
}
