using System;

namespace FlipBool
{
    internal class Program
    {
        internal static bool Flip(bool x)
        {
            if (x == true) return false;
            else return true;
        }

        private static void Main()
        {
            Console.WriteLine("What is the boolean you would like to be flipped?");
            var a = Console.ReadLine();
            if (bool.TryParse(a, out bool b)) Console.WriteLine(Flip(b));
            else throw new ArgumentException("Value given was not a valid boolean.");
            Console.ReadKey();
        }
    }
}