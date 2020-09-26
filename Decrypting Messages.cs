using System;
using System.Text;

namespace Decrypting_Messages
{
    class Program
    {
        static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine());
            int count = int.Parse(Console.ReadLine());
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < count; i++)
            {
                char input = char.Parse(Console.ReadLine());
                int result = key + (int)input;
                char endChar = (char)result; 
                sb.Append(endChar);
            }
            Console.WriteLine(sb);
        }
    }
}
