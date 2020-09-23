using System;

namespace _10._Lower_or_Upper
{
    class Program
    {
        static void Main(string[] args)
        {
            char characterInput = char.Parse(Console.ReadLine());
            if(char.IsLower(characterInput))
            {
                Console.WriteLine("lower-case");
            }
            else if(char.IsUpper(characterInput))
            {
                Console.WriteLine("upper-case");
            }
        }
    }
}
