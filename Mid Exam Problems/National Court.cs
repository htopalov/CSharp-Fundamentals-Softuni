using System;

namespace National_Court
{
    class Program
    {
        static void Main(string[] args)
        {
            int efficiency1 = int.Parse(Console.ReadLine());
            int efficiency2 = int.Parse(Console.ReadLine());
            int efficiency3 = int.Parse(Console.ReadLine());
            int peopleCount = int.Parse(Console.ReadLine());
            int peoplePerHour = efficiency1 + efficiency2 + efficiency3;
            int count = 0;
            while(peopleCount>0)
            {
                peopleCount -= peoplePerHour;
                count++;
                if(count%4==0)
                {
                    count++;
                }
            }
            Console.WriteLine($"Time needed: {count}h.");
        }  
    }
}
