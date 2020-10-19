using System;
using System.Collections.Generic;
using System.Linq;

namespace List_Manipulation_Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            string command = string.Empty;
            while(command!="end")
            {
                command = Console.ReadLine().ToLower();
                List<string> commandList = command.Split().ToList();
                switch(commandList[0])
                {
                    case "add": numbers.Add(int.Parse(commandList[1])); break;
                    case "remove": numbers.Remove(int.Parse(commandList[1])); break;
                    case "removeat": numbers.RemoveAt(int.Parse(commandList[1])); break;
                    case "insert": numbers.Insert(int.Parse(commandList[2]),int.Parse(commandList[1])); break;
                }
            }
            Console.WriteLine(string.Join(' ', numbers));
        }
    }
}
