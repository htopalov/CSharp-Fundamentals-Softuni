using System;
using System.Collections.Generic;
using System.Linq;

namespace Moving_Target
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> targets = Console.ReadLine().Split().Select(int.Parse).ToList();
            while (true)
            {
                string[] command = Console.ReadLine().Split().ToArray();
                string action = command[0];
                if (action == "End")
                {
                    break;
                }
                else
                {
                    int index = int.Parse(command[1]);
                    int value = int.Parse(command[2]);
                    switch (action)
                    {
                        case "Shoot":
                            if (index >= 0 && index < targets.Count)
                            {
                                targets[index] -= value;
                                if (targets[index] <= 0)
                                {
                                    targets.RemoveAt(index);
                                }
                            }
                            break;
                        case "Add":
                            if (index >= 0 && index < targets.Count)
                            {
                                targets.Insert(index, value);
                            }
                            else
                            {
                                Console.WriteLine("Invalid placement!");
                            }
                            break;
                        case "Strike":
                            if (index >= 0 && index < targets.Count)
                            {
                                if (index - value < 0 || index + value >= targets.Count)
                                {
                                    Console.WriteLine("Strike missed!");
                                    continue;
                                }
                                for (int i = index - value; i <= index + value; i++)
                                {
                                    targets.RemoveAt(index - value);
                                }
                            }

                            break;
                    }
                }

            }
            Console.WriteLine(string.Join('|', targets));
        }
    }
}
