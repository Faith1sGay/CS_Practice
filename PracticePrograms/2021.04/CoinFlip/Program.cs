using System;

namespace CoinFlip
{
    // Originally started on 2021.04, finished on 2022.09
    internal class Program
    {
        private static void Main()
        {
            int howManyTimes;
            Random rng = new();
            int numHeads = 0;
            int numTails = 0;
            Console.WriteLine("How many times would you like the coin to be flipped?");
            int.TryParse(Console.ReadLine(), out howManyTimes);
            for (int i = 0; i < howManyTimes; i++)
            {
                int coin = rng.Next(1, 3);
                if (coin == 1)
                {
                    numHeads++;
                }
                else
                {
                    numTails++;
                }
            }
            Console.WriteLine($"I flipped a coin {howManyTimes} times, and this is what happened :");
            Console.WriteLine($"Heads: {numHeads}\nTails: {numTails}");
            Console.WriteLine("Thanks for playing!");
        }
    }
}