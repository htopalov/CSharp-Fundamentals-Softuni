using System;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace Heart_Delivery
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] neighborhood = Console.ReadLine().Split('@').Select(int.Parse).ToArray();
            string input = Console.ReadLine();
            int jumpPosition = 0;
            while (input != "Love!")
            {
                string[] command = input.Split().ToArray();
                int jumpLength = int.Parse(command[1]);
                jumpPosition += jumpLength;
                if (jumpPosition >= 0 && jumpPosition < neighborhood.Length)
                {
                    neighborhood[jumpPosition] -= 2;
                }
                else
                {
                    jumpPosition = 0;
                    neighborhood[jumpPosition] -= 2;
                }
                if(neighborhood[jumpPosition] ==0)
                {
                    Console.WriteLine($"Place {jumpPosition} has Valentine's day.");
                }
                else if(neighborhood[jumpPosition]<0)
                {
                    Console.WriteLine($"Place {jumpPosition} already had Valentine's day.");
                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"Cupid's last position was {jumpPosition}.");
            int failCount = neighborhood.Count(x => x > 0);
            if (failCount ==0)
            {
                Console.WriteLine("Mission was successful.");
            }
            else
            {
                Console.WriteLine($"Cupid has failed {failCount} places.");
            }
        }
    }
}
