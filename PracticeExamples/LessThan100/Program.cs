using System;
namespace LessThan100
{
    static class Program
    {
        internal static bool LessThan100(int x, int y)
        {
            if (x + y < 100) return true;
            else return false;
        }
        internal static void Main()
        {
            Console.Write("What is your first number? ");
            var a = int.Parse(Console.ReadLine());
            Console.Write("What is your second number? ");
            var b = int.Parse(Console.ReadLine());
            Console.Write($"Is {a} + {b} larger or smaller than 100?\n{LessThan100(a, b)}");
        }
    }
}