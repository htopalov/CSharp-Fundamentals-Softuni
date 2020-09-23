using System;
using System.Linq;

namespace _2._English_Name_of_the_Last_Digit
{
    class Program
    {
        static void Main(string[] args)
        {
            LastDigit();
        }
        static void LastDigit()
        {
            string input = Console.ReadLine();
            char result = input.Last();
            string cwResult = null;
            switch(result)
            {
                case '0': cwResult = "zero"; break;
                case '1': cwResult = "one"; break;
                case '2': cwResult = "two"; break;
                case '3': cwResult = "three"; break;
                case '4': cwResult = "four"; break;
                case '5': cwResult = "five"; break;
                case '6': cwResult = "six"; break;
                case '7': cwResult = "seven"; break;
                case '8': cwResult = "eight"; break;
                case '9': cwResult = "nine"; break;
            }
            Console.WriteLine(cwResult);
        }
    }
}
