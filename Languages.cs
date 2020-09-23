using System;

namespace Languages
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            switch(name)
            {
                case "England":
                case "USA": Console.WriteLine("English"); break;
                case "Mexico":
                case "Argentina":
                case "Spain": Console.WriteLine("Spanish"); break;
                default: Console.WriteLine("unknown"); break;
            }
        }
    }
}
