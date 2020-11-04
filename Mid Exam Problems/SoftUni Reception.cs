using System;

namespace SoftUni_Reception
{
    class Program
    {
        static void Main(string[] args)
        {
            int employee1 = int.Parse(Console.ReadLine());
            int employee2 = int.Parse(Console.ReadLine());
            int employee3 = int.Parse(Console.ReadLine());
            int studentsCount = int.Parse(Console.ReadLine());
            int totalEff = employee1 + employee2 + employee3;
            int hours = 0;
            while(studentsCount>0)
            {
                studentsCount -= totalEff;
                hours++;
                if(hours%4==0)
                {
                    hours++;
                }
            }
            Console.WriteLine($"Time needed: {hours}h.");
        }
    }
}
