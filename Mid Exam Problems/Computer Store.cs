using System;

namespace Computer_Store
{
    class Program
    {
        static void Main(string[] args)
        {
            double totalPriceWithoutTaxes = 0;
            string command = string.Empty;
            while (true)
            {
                command = Console.ReadLine();
                if(command == "special" || command == "regular")
                {
                    break;
                }
                double inputPrice = double.Parse(command);
                if (inputPrice < 0)
                {
                    Console.WriteLine("Invalid price!");
                    continue;
                }
                totalPriceWithoutTaxes += inputPrice;
            }

            double taxes = totalPriceWithoutTaxes * 0.2;
            double totalPrice = totalPriceWithoutTaxes + taxes; ;
            if (totalPrice == 0)
            {
                Console.WriteLine("Invalid order!");
            }
            else if (totalPrice > 0)
            {
                Console.WriteLine("Congratulations you've just bought a new computer!");
                Console.WriteLine($"Price without taxes: {totalPriceWithoutTaxes:f2}$");
                Console.WriteLine($"Taxes: {taxes:f2}$");
                Console.WriteLine("-----------");
                if (command == "regular")
                {
                    Console.WriteLine($"Total price: {totalPrice:f2}$");
                }
                else if (command == "special")
                {
                    Console.WriteLine($"Total price: {totalPrice * 0.9:f2}$");
                }
            }

        }
    }
}
