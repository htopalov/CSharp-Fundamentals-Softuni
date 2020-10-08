using System;
using System.Linq;

namespace Array_Rotation
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputArr = Console.ReadLine().Split().ToArray();
            int rotations = int.Parse(Console.ReadLine());
            for (int i = 0; i < rotations; i++)
            {
                string firstElement = inputArr[0];
                for (int j = 1; j < inputArr.Length; j++)
                {
                    string currentElement = inputArr[j];
                    inputArr[j - 1] = currentElement;
                }
                inputArr[inputArr.Length - 1] = firstElement;
            }
            Console.WriteLine(string.Join(" ", inputArr));
        }
    }
}
