using System;

namespace Spice_Must_Flow
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = 0;
            int startingYeild = int.Parse(Console.ReadLine());
            int endDaySpice = 0;
            int totalSpice = 0;
            if (startingYeild < 100)
            {
                Console.WriteLine(days);
                Console.WriteLine(totalSpice);
            }
            else
            {
                while (startingYeild >= 100)
                {
                    endDaySpice = startingYeild - 26;
                    totalSpice += endDaySpice;
                    days++;
                    if (days > 0)
                    {
                        startingYeild -= 10;
                    }

                }
                Console.WriteLine(days);
                Console.WriteLine(totalSpice - 26);
            }
        }
    }
}
