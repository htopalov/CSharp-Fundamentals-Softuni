using System;

namespace Easter_Cozonacs
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            double priceForKgFlour = double.Parse(Console.ReadLine());
            double priceForEggs = priceForKgFlour * 0.75;
            double priceForLiterMilk = priceForKgFlour * 1.25;
            double priceForMilkForOneKozonak = priceForLiterMilk * 0.25;
            double priceForOneKozonak = priceForKgFlour + priceForEggs + priceForMilkForOneKozonak;
            int coloredEggs = 0;
            int kozonakCount = 0;
            while (priceForOneKozonak < budget)
            {
                budget -= priceForOneKozonak;
                kozonakCount++;
                coloredEggs += 3;
                if (kozonakCount % 3 == 0)
                {
                    coloredEggs -= kozonakCount - 2;
                }
            }
            Console.WriteLine($"You made {kozonakCount} cozonacs! Now you have {coloredEggs} eggs and {budget:f2}BGN left.");
        }
    }
}
