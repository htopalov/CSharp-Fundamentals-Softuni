using System;

namespace _12._Refactor_Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());  
            for (int i = 1; i <= number; i++)
            {
                int current = i;

                int sum = 0;
                while (current > 0)
                {
                    sum += current % 10;
                    current = current / 10;
                }
                bool isSpecial = false;
                isSpecial = (sum == 5) || (sum == 7) || (sum == 11);
                Console.WriteLine("{0} -> {1}", i, isSpecial);
                sum = 0;
            }

        }
    }
}
