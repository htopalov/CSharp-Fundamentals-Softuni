using System;
using System.Linq;

namespace Extract_Person_Information
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                string input = Console.ReadLine();
                int startIndexOfName = input.IndexOf('@');
                int lastIndexOfName = input.IndexOf('|');
                int startIndexOfAge = input.IndexOf('#');
                int lastIndexOfAge = input.IndexOf('*');
                string name = input.Substring(startIndexOfName+1, (lastIndexOfName - startIndexOfName)-1);
                string age = input.Substring(startIndexOfAge+1, (lastIndexOfAge - startIndexOfAge)-1);
                Console.WriteLine($"{name} is {age} years old.");
            }
        }
    }
}
