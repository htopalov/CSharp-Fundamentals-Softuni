using System;
using System.Collections.Generic;
using System.Linq;

namespace Cards_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstPlayer = Console.ReadLine()
                                        .Split()
                                        .Select(int.Parse)
                                        .ToList();
            List<int> secondPlayer = Console.ReadLine()
                                       .Split()
                                       .Select(int.Parse)
                                       .ToList();
            while(firstPlayer.Count !=0 && secondPlayer.Count!=0)
            {
                int firstPlayerCard = firstPlayer[0];
                int secondPlayerCard = secondPlayer[0];
                if(firstPlayerCard>secondPlayerCard)
                {
                    firstPlayer.Add(firstPlayerCard);
                    firstPlayer.Add(secondPlayerCard);
                }
                else if(firstPlayerCard<secondPlayerCard)
                {
                    secondPlayer.Add(secondPlayerCard);
                    secondPlayer.Add(firstPlayerCard);
                }
                firstPlayer.RemoveAt(0);
                secondPlayer.RemoveAt(0);
            }
            if(firstPlayer.Count ==0)
            {
                Console.WriteLine($"Second player wins! Sum: {secondPlayer.Sum()}");
            }
            else
            {
                Console.WriteLine($"First player wins! Sum: {firstPlayer.Sum()}");
            }    
        }
    }
}
