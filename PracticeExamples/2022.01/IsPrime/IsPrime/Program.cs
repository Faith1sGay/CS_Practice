using System;

namespace IsPrime
{
    // Updated on 2022.09.08
    internal static class Program
    {
        private static bool IsPrimeNumber(int num)
        {
            return num % 2 == 1;
        }

        private static void Main()
        {
            Console.WriteLine("Enter a number to check to see if it's prime or not : ");
            int.TryParse(Console.ReadLine(), out var number);
            Console.WriteLine(IsPrimeNumber(number));
            Console.ReadKey();
        }
    }
}