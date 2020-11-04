using System;

namespace Counter_Strike
{
    class Program
    {
        static void Main(string[] args)
        {
            int initial = int.Parse(Console.ReadLine());
            int distance = 0;
            int wins = 0;
            string command = string.Empty;
            while(initial >= 0)
            {
                command = Console.ReadLine();
                if(command=="End of battle")
                {
                    break;
                }
                else
                {
                    distance = int.Parse(command);
                    if (distance > initial)
                    {
                        Console.WriteLine($"Not enough energy! Game ends with {wins} won battles and {initial} energy");
                    }
                    initial -= distance;
                    wins++;
                    if(wins%3==0)
                    {
                        initial += wins;
                    }
                }
            }
            if (initial >= 0)
            {
                Console.WriteLine($"Won battles: {wins}. Energy left: {initial}");
            }
        }
    }
}
