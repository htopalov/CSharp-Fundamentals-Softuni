using System;

namespace Data_Type_Finder
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                string command = Console.ReadLine();
                if (command == "END")
                {
                    break;
                }
                else
                {
                    bool isDataTypeInt = int.TryParse(command, out int i);
                    bool isDataTypeFloat = double.TryParse(command, out double d);
                    bool isDataTypeChar = char.TryParse(command, out char c);
                    bool isDataTypeBool = bool.TryParse(command, out bool b);
                    if (isDataTypeInt)
                    {
                        Console.WriteLine($"{command} is integer type");
                    }
                    else if (isDataTypeFloat)
                    {
                        Console.WriteLine($"{command} is floating point type");
                    }
                    else if (isDataTypeChar)
                    {
                        Console.WriteLine($"{command} is character type");
                    }
                    else if (isDataTypeBool)
                    {
                        Console.WriteLine($"{command} is boolean type");
                    }
                    else
                    {
                        Console.WriteLine($"{command} is string type");
                    }
                }
            }
        }
    }
}
