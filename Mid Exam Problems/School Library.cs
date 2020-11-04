using System;
using System.Collections.Generic;
using System.Linq;

namespace School_Library
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> bookShelf = Console.ReadLine()
                                        .Split('&')
                                        .ToList();
            string command = Console.ReadLine();
            while (command != "Done")
            {
                string[] commandArguments = command.Split(" | ");
                switch (commandArguments[0])
                {
                    case "Add Book":
                        if (!bookShelf.Contains(commandArguments[1]))
                        {
                            bookShelf.Insert(0, commandArguments[1]);
                        }
                        break;
                    case "Take Book":
                        if (bookShelf.Contains(commandArguments[1]))
                        {
                            bookShelf.Remove(commandArguments[1]);
                        }
                        break;
                    case "Swap Books":
                        if (bookShelf.Contains(commandArguments[1]) && bookShelf.Contains(commandArguments[2]))
                        {
                            int indexOfBook1 = bookShelf.IndexOf(commandArguments[1]);
                            int indexOfBook2 = bookShelf.IndexOf(commandArguments[2]);
                            string temp = bookShelf[indexOfBook1];
                            bookShelf[indexOfBook1] = bookShelf[indexOfBook2];
                            bookShelf[indexOfBook2] = temp;
                        }
                        break;
                    case "Insert Book":
                        bookShelf.Add(commandArguments[1]);
                        break;
                    case "Check Book":
                        if (int.Parse(commandArguments[1]) >= 0 && int.Parse(commandArguments[1]) < bookShelf.Count)
                        {
                            Console.WriteLine(bookShelf[int.Parse(commandArguments[1])]);
                        }
                        break;
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(", ",bookShelf));
        }
    }
}
