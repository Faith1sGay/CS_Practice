using System;

namespace EvenOrOddDetector
{
    // Started on 2021.03, finished on 2022.09
    internal sealed class Program
    {
        private static string IsEvenOrOdd(int x)
        {
            if (x % 2 == 0) return "Even.";
            else return "Odd.";
        }

        private static void Main() => Console.WriteLine(IsEvenOrOdd(int.Parse(Console.ReadLine())));
    }
}