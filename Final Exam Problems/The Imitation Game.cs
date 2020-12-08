using System;

namespace The_Imitation_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();
            string command = Console.ReadLine();
            while (command!="Decode")
            {
                string[] arguments = command.Split("|", StringSplitOptions.RemoveEmptyEntries);
                string action = arguments[0];
                switch(action)
                {
                    case "Move":
                        int lettersCount = int.Parse(arguments[1]);
                        string substr = message.Substring(0, lettersCount);
                        message = message.Remove(0, lettersCount);
                        message = message.Insert(message.Length, substr);
                        break;
                    case "Insert":
                        int index = int.Parse(arguments[1]);
                        string value = arguments[2];
                        message = message.Insert(index, value);
                        break;
                    case "ChangeAll":
                        string oldStr = arguments[1];
                        string newStr = arguments[2];
                        message = message.Replace(oldStr, newStr);
                        break;
                }
                command = Console.ReadLine();
            }
            Console.WriteLine($"The decrypted message is: {message}");
        }
    }
}
