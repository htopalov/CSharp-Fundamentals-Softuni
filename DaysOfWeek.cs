using System;

namespace DaysOfWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] daysOfWeek =
            {
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday"
            };
            int inputNum = int.Parse(Console.ReadLine());
            if(inputNum<1 || inputNum>daysOfWeek.Length)
            {
                Console.WriteLine("Invalid day!");
            }
            else
            {
                Console.WriteLine(daysOfWeek[inputNum-1]);
            }
        }
    }
}
