using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftUni_Course_Planning
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> schedule = Console.ReadLine().Split(", ").ToList();
            string commands = Console.ReadLine();

            while (commands != "course start")
            {
                string[] commandArguments = commands.Split(":").ToArray();
                switch (commandArguments[0])
                {
                    case "Add":
                        if (!schedule.Contains(commandArguments[1]))
                        {
                            schedule.Add(commandArguments[1]);
                        }
                        break;

                    case "Insert":
                        if (!schedule.Contains(commandArguments[1]))
                        {
                            schedule.Insert(int.Parse(commandArguments[2]), commandArguments[1]);
                        }
                        break;

                    case "Remove":
                        if (schedule.Contains(commandArguments[1]))
                        {
                            int index = schedule.IndexOf(commandArguments[1]);

                            if (schedule.Contains(commandArguments[1] + "-Exercise"))
                            {
                                schedule.RemoveRange(index, 1);
                            }
                            else
                            {
                                schedule.Remove(commandArguments[1]);
                            }

                        }
                        break;

                    case "Swap":
                        string lessonTitle1 = commandArguments[1];
                        string lessonTitle2 = commandArguments[2];
                        int index1 = schedule.IndexOf(lessonTitle1);
                        int index2 = schedule.IndexOf(lessonTitle2);
                        //if lessons exist-swap their places
                        if (schedule.Contains(lessonTitle1) && schedule.Contains(lessonTitle2))
                        {
                            string temp = schedule.ElementAt(index1);
                            schedule[index1] = schedule[index2];
                            schedule[index2] = temp;
                        }
                        if (schedule.Contains(lessonTitle1 + "-Exercise") && schedule.Contains(schedule[index1]))
                        {
                            index1 = schedule.IndexOf(lessonTitle1);
                            schedule.Remove(lessonTitle1 + "-Exercise");
                            schedule.Insert(index1 + 1, lessonTitle1 + "-Exercise");
                        }
                        else if (schedule.Contains(lessonTitle2 + "-Exercise") && schedule.Contains(schedule[index2]))
                        {
                            index2 = schedule.IndexOf(lessonTitle2);
                            schedule.Remove(lessonTitle2 + "-Exercise");
                            schedule.Insert(index2 + 1, lessonTitle2 + "-Exercise");
                        }
                        break;

                    case "Exercise":
                        string lessonTitle = commandArguments[1];

                        if (schedule.Contains(lessonTitle) && !schedule.Contains(lessonTitle + "-Exercise"))
                        {
                            int index = schedule.IndexOf(lessonTitle);
                            schedule.Insert(index + 1, lessonTitle + "-Exercise");
                        }
                        else if (!schedule.Contains(lessonTitle))
                        {
                            schedule.Add(lessonTitle);
                            schedule.Add(lessonTitle + "-Exercise");
                        }
                        break;
                }
                commands = Console.ReadLine();
            }
            for (int i = 0; i <schedule.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{schedule[i]}");
            }
        }
    }
}
