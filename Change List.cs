using System;
using System.Collections.Generic;
using System.Linq;

namespace Change_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                                .Split()
                                .Select(int.Parse)
                                .ToList();

            string command = Console.ReadLine().ToUpper();
            while(command !="END")
            {
                string[] commandArr = command.Split();
                bool isContained = numbers.Contains(int.Parse(commandArr[1]));
                switch(commandArr[0])
                {
                    case "DELETE":
                        if(isContained)
                        {
                            for (int i = 0; i < numbers.Count; i++)
                            {
                                numbers.Remove(int.Parse(commandArr[1]));
                            }
                        }
                        break;
                    case "INSERT":
                        numbers.Insert(int.Parse(commandArr[2]), int.Parse(commandArr[1]));
                        break;
                }
                 command = Console.ReadLine().ToUpper();
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
