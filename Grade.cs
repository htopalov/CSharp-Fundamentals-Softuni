using System;

namespace Grade
{
    class Program
    {
        static void Main(string[] args)
        {
            Grade(double.Parse(Console.ReadLine()));
        }
        static void Grade(double input)
        {
            if(input >= 2.00 && input<=2.99)
            {
                Console.WriteLine("Fail");
            }
            else if(input>= 3.00 && input<= 3.49)
            {
                Console.WriteLine("Poor");
            }
            else if (input >= 3.50 && input <= 4.49)
            {
                Console.WriteLine("Good");
            }
            else if (input >= 4.50 && input <= 5.49)
            {
                Console.WriteLine("Very good");
            }
            else if (input >= 5.50 && input <= 6.00)
            {
                Console.WriteLine("Excellent");
            }

        }
    }
}
