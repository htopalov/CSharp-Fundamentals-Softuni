using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> menuCollection = new Dictionary<string, List<string>>();
            string command = Console.ReadLine();
            int count = 0;
            while (command != "Stop")
            {
                string[] arguments = command.Split("-", StringSplitOptions.RemoveEmptyEntries);
                string preference = arguments[0];
                string person = arguments[1];
                string dish = arguments[2];

                if (preference == "Like")
                {
                    if (!menuCollection.ContainsKey(person))
                    {
                        menuCollection.Add(person, new List<string>() { dish });
                    }
                    else if (!menuCollection[person].Contains(dish))
                    {
                        menuCollection[person].Add(dish);
                    }
                }

                else if (preference == "Unlike")
                {
                    if (!menuCollection.ContainsKey(person))
                    {
                        Console.WriteLine($"{person} is not at the party.");

                    }
                    else if (!menuCollection[person].Contains(dish))
                    {
                        Console.WriteLine($"{person} doesn't have the {dish} in his/her collection.");
                    }
                    else
                    {
                        menuCollection[person].Remove(dish);
                        Console.WriteLine($"{person} doesn't like the {dish}.");
                        count++;
                    }
                }
                command = Console.ReadLine();
            }

            foreach (var item in menuCollection.OrderByDescending(x => x.Value.Count).ThenBy(y => y.Key))
            {
                Console.WriteLine($"{item.Key}: {string.Join(", ", item.Value)}");
            }

            Console.WriteLine($"Unliked meals: {count}");
        }
    }
}
