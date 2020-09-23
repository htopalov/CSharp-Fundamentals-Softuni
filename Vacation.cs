using System;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int groupCount = int.Parse(Console.ReadLine());
            string typeOfGroup = Console.ReadLine();
            string day = Console.ReadLine();
            double price = 0;
            double totalPrice = 0;

            switch(typeOfGroup)
            {
                case "Students": 
                    if(day=="Friday")
                    {
                        price = 8.45;
                    }
                    else if(day == "Saturday")
                    {
                        price = 9.80;
                    }
                    else if(day=="Sunday")
                    {
                        price = 10.46;
                    }
                    break;
                case "Business":
                    if (day == "Friday")
                    {
                        price = 10.90;
                    }
                    else if (day == "Saturday")
                    {
                        price = 15.60;
                    }
                    else if (day == "Sunday")
                    {
                        price = 16;
                    }
                    break;
                case "Regular":
                    if (day == "Friday")
                    {
                        price = 15;
                    }
                    else if (day == "Saturday")
                    {
                        price = 20;
                    }
                    else if (day == "Sunday")
                    {
                        price = 22.50;
                    }
                    break;
            }
            totalPrice = price * groupCount;
            if(groupCount>=30 && typeOfGroup =="Students")
            {
                totalPrice *= 0.85;
            }
            if(groupCount>=100 && typeOfGroup=="Business")
            {
                switch(day)
                {
                    case "Friday":
                        totalPrice -= 10 * 10.90; break;
                    case "Saturday":
                        totalPrice -= 10 * 15.60; break;
                    case "Sunday":
                        totalPrice -= 10 * 16; break;
                }
            }
            if(groupCount>=10 && groupCount<=20 && typeOfGroup=="Regular")
            {
                totalPrice *= 0.95;
            }
            Console.WriteLine($"Total price: {totalPrice:f2}");
        }
    }
}
