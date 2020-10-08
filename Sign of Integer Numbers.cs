using System;

namespace Sign_of_Integer_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            IntSign(int.Parse(Console.ReadLine())); 
        }
        static void IntSign(int input)
        {
            if(input==0)
            {
                Console.WriteLine($"The number {input} is zero.");
            }
            else if(input>0)
            {
                Console.WriteLine($"The number {input} is positive.");
            }
            else
            {
                Console.WriteLine($"The number {input} is negative.");
            }
        }
    }
}
