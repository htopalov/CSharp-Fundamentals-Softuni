using System;

namespace Ascii_Sumator
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstChar = char.Parse(Console.ReadLine());
            char secondChar = char.Parse(Console.ReadLine());
            string str = Console.ReadLine();
            int sum = 0;
            int start = (int)Math.Min(firstChar, secondChar);
            int end = (int)Math.Max(firstChar, secondChar);
            for (int i = 0; i < str.Length; i++)
            {
                int current = (int)(str[i]);
                if (current > start && current < end)
                {
                    sum += current;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
