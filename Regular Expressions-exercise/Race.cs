using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Race
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] listPeople = Console.ReadLine().Split(", ");
            Dictionary<string, int> peopleAndPoint = new Dictionary<string, int>();
            foreach (string name in listPeople)
            {
                peopleAndPoint.Add(name, 0);
            }
            string namePatern = @"[\W\d]";
            string numberPattern = @"[\WA-z]";
            string input = Console.ReadLine();
            while(input!="end of race")
            {
                string name = Regex.Replace(input, namePatern, "");
                string number = Regex.Replace(input, numberPattern, "");
                int total = 0;
                foreach (var item in number)
                {
                    int currentNumber = int.Parse(item.ToString());
                    total += currentNumber;
                }
                if (peopleAndPoint.ContainsKey(name))
                {
                    peopleAndPoint[name] += total;
                }
                input = Console.ReadLine();
            }
            int count = 1;
            foreach (var item in peopleAndPoint.OrderByDescending(x=>x.Value))
            {
                string text = count == 1 ? "st" : count == 2 ? "nd" : "rd";
                Console.WriteLine($"{count++}{text} place: {item.Key}");
                if (count == 4)
                {
                    break;
                }
            }

        }
    }
}
