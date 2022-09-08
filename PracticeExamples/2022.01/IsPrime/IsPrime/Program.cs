using System;
namespace IsPrime
{
    static internal class Program
    {
        static bool IsPrimeNumber(int num)
        {
            if (num % 2 == 0) return false;
            else return true;
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