using System;

namespace Calculate_Rectangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
           int result = RectangleArea(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
           Console.WriteLine(result);
        }
        static int RectangleArea(int width, int heigth)
        {
            int area = width * heigth;
            return area;
        }
    }
}
