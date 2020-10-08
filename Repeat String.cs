using System;
using System.Text;

namespace Repeat_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string result = RepeatFunction(Console.ReadLine(), int.Parse(Console.ReadLine()));
            Console.WriteLine(result);
        }
        static string RepeatFunction(string text, int count)
        {
            StringBuilder strBuild = new StringBuilder();
            for (int i = 1; i <= count; i++)
            {
                strBuild.Append(text);
            }
            return strBuild.ToString();
        }
    }
}
