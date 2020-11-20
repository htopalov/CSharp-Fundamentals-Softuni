using System;

namespace Extract_File
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(@"\");
            string[] nameAndExtension = input[input.Length - 1].Split('.');
            Console.WriteLine($"File name: {nameAndExtension[0]}");
            Console.WriteLine($"File extension: {nameAndExtension[1]}");
        }
    }
}
