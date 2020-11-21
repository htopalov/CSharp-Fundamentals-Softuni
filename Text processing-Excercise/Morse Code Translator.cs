using System;
using System.Collections.Generic;
using System.Text;

namespace Morse_Code_Translator
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> alphabets = new Dictionary<string, string>();
            alphabets.Add(".-", "A");
            alphabets.Add("-...", "B");
            alphabets.Add("-.-.", "C");
            alphabets.Add("-..", "D");
            alphabets.Add(".", "E");
            alphabets.Add("..-.", "F");
            alphabets.Add("--.", "G");
            alphabets.Add("....", "H");
            alphabets.Add("..", "I");
            alphabets.Add(".---", "J");
            alphabets.Add("-.-", "K");
            alphabets.Add(".-..", "L");
            alphabets.Add("--", "M");
            alphabets.Add("-.", "N");
            alphabets.Add("---", "O");
            alphabets.Add(".--.", "P");
            alphabets.Add("--.-", "Q");
            alphabets.Add(".-.", "R");
            alphabets.Add("...", "S");
            alphabets.Add("-", "T");
            alphabets.Add("..-", "U");
            alphabets.Add("...-", "V");
            alphabets.Add(".--", "W");
            alphabets.Add("-..-", "X");
            alphabets.Add("-.--", "Y");
            alphabets.Add("--..", "Z");
            string[] input = Console.ReadLine().Split(" | ");
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < input.Length; i++)
            {
                string[] splitted = input[i].Split();
                for (int j = 0; j < splitted.Length; j++)
                {
                    if (alphabets.ContainsKey(splitted[j]))
                    {
                        string letter = alphabets[splitted[j]];
                        sb.Append(letter);
                    }
                }
                sb.Append(" ");
            }
            Console.WriteLine(sb.ToString());
        }
    }
}
