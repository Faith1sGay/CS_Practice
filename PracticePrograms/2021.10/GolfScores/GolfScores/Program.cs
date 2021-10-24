using System;

namespace GolfScores
{
    internal static class Program
    {
        private static void Main()
        {
            Console.WriteLine("Please enter the par for the golf hole: ");
            int.TryParse(Console.ReadLine(), out int par);
            Console.WriteLine("Now please enter the amount of shots taken for that hole: ");
            int.TryParse(Console.ReadLine(), out int shots);
            var eagle = par - 2;
            var birdie = par - 1;
            var bogey = par + 1;
            if (par is 3 or 4 or 5)
            {
                if (shots == par)
                {
                    Console.WriteLine("Par");
                }
                else if (shots == eagle)
                {
                    Console.WriteLine("Eagle");
                }
                else if (shots == birdie)
                {
                    Console.WriteLine("Birdie");
                }
                else if (shots == bogey)
                {
                    Console.WriteLine("Bogey");
                }
            }
            else
            {
                throw new Exception("The par must be 3 or 4 or 5 and the shots must be either up to 2 below par or one above par.");
            }
        }
    }
}