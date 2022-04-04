using System;

namespace FindTheBomb
{
    internal class Program
    {
        private static string Bomb(string x)
        {
            if (x.Contains("bomb".ToLower()))
            {
                return "Duck!!!";
            }
            else
            {
                return "There is no bomb, relax.";
            }
        }

        private static void Main() => Console.WriteLine(Bomb(Console.ReadLine()));
    }
}