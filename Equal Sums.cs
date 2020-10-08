using System;
using System.Linq;

namespace Equal_Sums
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputArr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            bool isFound = false;
            for (int i = 0; i < inputArr.Length; i++)
            {
                int rightSum = 0;
                for (int j = i+1; j < inputArr.Length; j++)
                {
                    rightSum += inputArr[j];
                }
                int leftSum = 0;
                for (int k = i-1; k >=0; k--)
                {
                    leftSum += inputArr[k];
                }
                if(leftSum==rightSum)
                {
                    Console.WriteLine(i);
                    isFound = true;
                    break;
                }
            }
            if(!isFound)
            {
                Console.WriteLine("no");
            }


        }
    }
}
