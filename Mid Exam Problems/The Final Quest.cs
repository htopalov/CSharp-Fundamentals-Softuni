using System;
using System.Collections.Generic;
using System.Linq;

namespace The_Final_Quest
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> wordsCollection = Console.ReadLine().Split(' ').ToList();
            string command = Console.ReadLine();
            while (command != "Stop")
            {
                string[] commandArguments = command.Split(' ').ToArray();
                switch (commandArguments[0])
                {
                    case "Delete":
                        if (int.Parse(commandArguments[1]) > 0 && int.Parse(commandArguments[1]) < wordsCollection.Count)
                        {
                            wordsCollection.RemoveAt(int.Parse(commandArguments[1]) + 1);
                        }
                        break;
                    case "Swap":
                        if (wordsCollection.Contains(commandArguments[1]) && wordsCollection.Contains(commandArguments[2]))
                        {
                            int indexWord1 = wordsCollection.IndexOf(commandArguments[1]);
                            int indexWord2 = wordsCollection.IndexOf(commandArguments[2]);
                            string temp = wordsCollection[indexWord1];
                            wordsCollection[indexWord1] = wordsCollection[indexWord2];
                            wordsCollection[indexWord2] = temp;
                        }
                        break;
                    case "Put":
                        if (int.Parse(commandArguments[2]) > 0 && int.Parse(commandArguments[2]) < wordsCollection.Count)
                        {
                            if (int.Parse(commandArguments[2]) == wordsCollection.Count - 1)
                            {
                                wordsCollection.Add(commandArguments[1]);
                            }
                            else
                            {
                                wordsCollection.Insert(int.Parse(commandArguments[2]) - 1, commandArguments[1]);
                            }
                        }
                        break;
                    case "Sort":
                        wordsCollection.Sort();
                        break;
                    case "Replace":
                        if(wordsCollection.Contains(commandArguments[2]))
                        {
                            int indexOfWord = wordsCollection.IndexOf(commandArguments[2]);
                            wordsCollection[indexOfWord] = commandArguments[1];
                        }
                        break;
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(' ', wordsCollection));
        }
    }
}
