using System;

namespace _11._Refactor_Volume_of_Pyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Length: ");
            double lenght = double.Parse(Console.ReadLine());
            Console.Write("Width: ");
            double width = double.Parse(Console.ReadLine());
            Console.Write("Height: ");
            double height = double.Parse(Console.ReadLine());
            double volume = (lenght * width * height)/3;
            Console.Write($"Pyramid Volume: {volume:f2}");

        }
    }
}
