using System;
using System.Collections.Generic;
using System.Linq;

namespace Messaging
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> chatCollection = new List<string>();
            string command = Console.ReadLine();
            while(command!="end")
            {
                string[] commandArguments = command.Split().ToArray();
                switch(commandArguments[0])
                {
                    case "Chat":
                            chatCollection.Add(commandArguments[1]);
                        break;
                    case "Delete":
                        if(chatCollection.Contains(commandArguments[1]))
                        {
                            chatCollection.Remove(commandArguments[1]);
                        }
                        break;
                    case "Edit":
                        int index = chatCollection.IndexOf(commandArguments[1]);
                        chatCollection[index] = commandArguments[2];
                        break;
                    case "Pin":
                        int indexPin = chatCollection.IndexOf(commandArguments[1]);
                        chatCollection.Add(commandArguments[1]);
                        chatCollection.RemoveAt(indexPin);
                        break;
                    case "Spam":
                            for (int j = 0; j < commandArguments.Length; j++)
                            {
                                if (commandArguments[j] != "Spam")
                                {
                                        chatCollection.Add(commandArguments[j]);
                                }
                            }

                        break;
                }
                command = Console.ReadLine();
            }
            foreach (string word in chatCollection)
            {
                Console.WriteLine(word);
            }
        }
    }
}
