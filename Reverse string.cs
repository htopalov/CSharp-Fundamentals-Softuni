using System;

namespace Reverse_string
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string result = null;
            for(int i = input.Length; i>=0; i--)
            {
                result += input[i];
            }
            Console.WriteLine(result);
        }
    }
}
