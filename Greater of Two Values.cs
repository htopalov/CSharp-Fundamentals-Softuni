using System;

namespace Greater_of_Two_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            if(type =="int")
            {
                int num1 = int.Parse(Console.ReadLine());
                int num2 = int.Parse(Console.ReadLine());
                int result = GetMax(num1, num2);
                Console.WriteLine(result);
            }
            else if(type=="char")
            {
                char letter1 = char.Parse(Console.ReadLine());
                char letter2 = char.Parse(Console.ReadLine());
                char result = GetMax(letter1, letter2);
                Console.WriteLine(result);
            }
            else if(type =="string")
            {
                string text1 = Console.ReadLine();
                string text2 = Console.ReadLine();
                string result = GetMax(text1, text2);
                Console.WriteLine(result);
            }

        }
        static int GetMax(int input1, int input2)
        {
            if(input1>input2)
            {
                return input1;
            }
            else
            {
                return input2;
            }
        }
        static char GetMax(char input1, char input2)
        {
            if(input1.CompareTo(input2)>0)
            {
                return input1;
            }
            else
            {
                return input2;
            }
        }
        static string GetMax(string input1, string input2)
        {
            if(input1.CompareTo(input2)>0)
            {
                return input1;
            }
            else
            {
                return input2;
            }
        }
    }
}
