using System;

namespace LessThan100
{
    // Updated on 2022.09.08
    internal static class Program
    {
        internal static bool LessThan100(int x, int y)
        {
            return x + y < 100;
        }

        internal static void Main()
        {
            Console.Write("What is your first number? ");
            var a = int.Parse(Console.ReadLine());
            Console.Write("What is your second number? ");
            var b = int.Parse(Console.ReadLine());
            Console.Write($"Is {a} + {b} smaller than 100?\n{LessThan100(a, b)}");
        }
    }
}