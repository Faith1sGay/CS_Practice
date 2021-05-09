using System;
namespace CoinFlip
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime start = DateTime.Now;
            Random rng = new Random();
            var coin = rng.Next(0, 1);
            int numHeads = 0;
            int numTails = 0;
            foreach (int _ in coin)
            {

            }
        }
    }
}
