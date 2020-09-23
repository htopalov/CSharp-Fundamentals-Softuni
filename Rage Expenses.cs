using System;

namespace Rage_Expenses
{
    class Program
    {
        static void Main(string[] args)
        {
            int lostGamesCount = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());
            int headset = 0;
            int mouse = 0;
            int keyboard = 0;
            int display = 0;
            for (int i = 1; i <= lostGamesCount; i++)
            {
                if(i%2==0)
                {
                    headset++;
                }
                if(i%3==0)
                {
                    mouse++;
                }
                if(i%6==0)
                {
                    keyboard++;
                }
                if(i%12==0)
                {
                    display++;
                }
            }
            double totalMoney = headsetPrice * headset + mousePrice * mouse + keyboardPrice * keyboard + displayPrice * display;
            Console.WriteLine($"Rage expenses: {totalMoney:f2} lv.");
        }
    }
}
