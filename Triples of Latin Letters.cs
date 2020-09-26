using System;

namespace Triples_of_Latin_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            char firstChar;
            char secondChar;
            char thirdChar;
            for (int i = 0; i < count; i++)
            {
                firstChar = (char)('a' + i);
                for (int j = 0; j < count; j++)
                {
                    secondChar = (char)('a' + j);
                    for (int k = 0; k < count; k++)
                    {
                        thirdChar = (char)('a' + k);
                        Console.WriteLine($"{firstChar}{secondChar}{thirdChar}");
                    }
                }
            }
        }
    }
}
