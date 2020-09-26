using System;

namespace Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfPeople = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());
            int courses = numberOfPeople / capacity;
            if(numberOfPeople % capacity != 0)
            {
                courses += 1;
            }
            Console.WriteLine(courses);
        }
    }
}
