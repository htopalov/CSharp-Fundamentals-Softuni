using System;

namespace Text_Filter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] bannedWords = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
            string text = Console.ReadLine();
            foreach (var word in bannedWords)
            {
                for (int i = 0; i < text.Length; i++)
                {
                    string replace = new string('*', word.Length);
                    text = text.Replace(word, replace);
                }
            }
            Console.WriteLine(text);
        }
    }
}
