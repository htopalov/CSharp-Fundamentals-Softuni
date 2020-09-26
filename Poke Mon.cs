using System;

namespace Poke_Mon
{
    class Program
    {
        static void Main(string[] args)
        {
            int pokePowerN = int.Parse(Console.ReadLine());
            int pokeTargetsM = int.Parse(Console.ReadLine());
            int exhaustionFactorY = int.Parse(Console.ReadLine());
            int targetsCount = 0;
            int pokePowerOriginalValue = pokePowerN;
            while(pokePowerN>=pokeTargetsM)
            {
                pokePowerN -= pokeTargetsM;
                targetsCount++;
                if (pokePowerN == (decimal)(pokePowerOriginalValue * 0.5) && exhaustionFactorY !=0)
                {
                        pokePowerN /= exhaustionFactorY;
                }
            }
            Console.WriteLine(pokePowerN);
            Console.WriteLine(targetsCount);
        }
    }
}
