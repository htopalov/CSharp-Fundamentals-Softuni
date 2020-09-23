using System;

namespace _6._Reversed_Chars
{
    class Program
    {
        static void Main(string[] args)
        {
            string result = null;
            string result2 = null;
            for (int i = 1; i <= 3; i++)
            {
                char letter = char.Parse(Console.ReadLine());
                result += letter;
            }
            for (int i = result.Length-1; i >=0; i--)
            {
                result2 +=result[i];
                Console.Write(result2);
                Console.Write(' ');
                result2 = null;
            }
        }
    }
}
