using System;
using System.Linq;

namespace MuOnline
{
    class Program
    {
        static void Main(string[] args)
        {
            int health = 100;
            int bitcoins = 0;
            string[] room = Console.ReadLine().Split("|").ToArray();
            for (int i = 0; i < room.Length; i++)
            {
                string[] command = room[i].Split().ToArray();
                if (command[0] == "potion")
                {
                    int currentHealth = health;
                    int tempHealth = health;
                    currentHealth += int.Parse(command[1]);
                    if (currentHealth > 100)
                    { 
                        int difference = 100 - tempHealth;
                        health = 100;
                        Console.WriteLine($"You healed for {difference} hp.");
                        Console.WriteLine($"Current health: {health} hp.");
                    }
                    else
                    {
                        health += int.Parse(command[1]);
                        Console.WriteLine($"You healed for {command[1]} hp.");
                        Console.WriteLine($"Current health: {health} hp.");
                    }  
                }
                else if (command[0] == "chest")
                {
                    bitcoins += int.Parse(command[1]);
                    Console.WriteLine($"You found {int.Parse(command[1])} bitcoins.");
                }
                else
                {
                    health -= int.Parse(command[1]);
                    if (health <= 0)
                    {
                        Console.WriteLine($"You died! Killed by {command[0]}.");
                        Console.WriteLine($"Best room: {i + 1}");
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"You slayed {command[0]}.");
                    }
                }
            }
            if (health > 0)
            {
                Console.WriteLine("You've made it!");
                Console.WriteLine($"Bitcoins: {bitcoins}");
                Console.WriteLine($"Health: {health}");
            }

        }
    }
}
