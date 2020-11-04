using System;

namespace Disneyland_Journey
{
    class Program
    {
        static void Main(string[] args)
        {
            double journeyCost = double.Parse(Console.ReadLine());
            int months = int.Parse(Console.ReadLine());
            double savedMoney = 0;
            for (int i = 1; i <= months; i++)
            {
                if (i % 4 == 0)
                {
                    savedMoney += savedMoney * 0.25; //bonus from boss
                }
                if (i % 2 != 0 && i != 1)
                {
                    savedMoney -= savedMoney * 0.16; //spend for clothes and shoes
                }
                savedMoney += journeyCost * 0.25; //saved money every month
            }
            if(savedMoney>journeyCost)
            {
                Console.WriteLine($"Bravo! You can go to Disneyland and you will have {savedMoney-journeyCost:f2}lv. for souvenirs.");
            }
            else
            {
                Console.WriteLine($"Sorry. You need {journeyCost-savedMoney:f2}lv. more.");
            }
        }
    }
}
