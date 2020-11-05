using System;
using System.Collections.Generic;
using System.Linq;

namespace Seize_the_Fire
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] fireCells = Console.ReadLine().Split('#');
            int water = int.Parse(Console.ReadLine());
            double effort = 0;
            double totalFire = 0;
            List<int> listToPrint = new List<int>();
            for (int i = 0; i < fireCells.Length; i++)
            {
                string[] fire = fireCells[i].Split(" = ");
                switch(fire[0])
                {
                    case "High":
                        if(water< int.Parse(fire[1]))
                        {
                            break;
                        }
                        if(int.Parse(fire[1])>=81 && int.Parse(fire[1])<=125)
                        {
                            water -= int.Parse(fire[1]);
                            effort += int.Parse(fire[1]) * 0.25;
                            totalFire += int.Parse(fire[1]);
                            listToPrint.Add(int.Parse(fire[1]));
                        }
                        break;
                    case "Medium":
                        if (water < int.Parse(fire[1]))
                        {
                            break;
                        }
                        if (int.Parse(fire[1]) >= 51 && int.Parse(fire[1]) <= 80)
                        {
                            water -= int.Parse(fire[1]);
                            effort += int.Parse(fire[1]) * 0.25;
                            totalFire += int.Parse(fire[1]);
                            listToPrint.Add(int.Parse(fire[1]));
                        }
                        break;
                    case "Low":
                        if (water < int.Parse(fire[1]))
                        {
                            break;
                        }
                        if (int.Parse(fire[1]) >= 1 && int.Parse(fire[1]) <= 50)
                        {
                            water -= int.Parse(fire[1]);
                            effort += int.Parse(fire[1]) * 0.25;
                            totalFire += int.Parse(fire[1]);
                            listToPrint.Add(int.Parse(fire[1]));
                        }
                        break;
                }
            }
            for (int i = 0; i < listToPrint.Count; i++)
            {
                Console.WriteLine($"- {listToPrint[i]}");
            }
            Console.WriteLine($"Effort: {effort:F2}");
            Console.WriteLine($"Total Fire: {totalFire}");
        }
    }
}
