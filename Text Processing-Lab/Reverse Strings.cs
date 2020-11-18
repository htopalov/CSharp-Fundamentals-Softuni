using System;
using System.Linq;

namespace Reverse_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            while (input != "end")
            {
                string reversed = string.Empty;
                for (int i = input.Length-1; i >= 0; i--)
                {
                    reversed += input[i];
                }
                Console.WriteLine($"{input} = {reversed}");
                input = Console.ReadLine();
            }
        }
    }
}
