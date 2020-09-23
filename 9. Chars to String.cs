using System;

namespace _9._Chars_to_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string result = null;
            for (int i = 1; i <= 3; i++)
            {
                char letter = char.Parse(Console.ReadLine());
                result += letter;
            }
            Console.WriteLine(result);
        }
    }
}
