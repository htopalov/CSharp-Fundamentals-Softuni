using System;
using System.Linq;

namespace The_Lift
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalPeople = int.Parse(Console.ReadLine());
            int[] lift = Console.ReadLine()
                            .Split()
                            .Select(int.Parse)
                            .ToArray();
            bool freeSpots = false;
            for (int i = 0; i < lift.Length; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (lift[i] < 4)
                    {
                        if(totalPeople==0)
                        {
                            break;         
                        }
                        lift[i] += 1;
                        totalPeople -= 1;
                    }
                }
                if(lift[i]<4)
                {
                    freeSpots = true;
                }
            }
            if (totalPeople == 0 && freeSpots)
            {
                Console.WriteLine("The lift has empty spots!");
                Console.WriteLine(string.Join(' ', lift));
            }
            else if (totalPeople > 0 && !freeSpots)
            {
                Console.WriteLine($"There isn't enough space! {totalPeople} people in a queue!");
                Console.WriteLine(string.Join(' ', lift));
            }
            else
            {
                Console.WriteLine(string.Join(' ', lift));
            }
        }
    }
}
