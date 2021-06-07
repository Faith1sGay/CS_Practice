using System;
namespace ReturnSum
{
    internal class Program
    {
        public static int Sum(int x, int y)
        {
            int sum = x + y;
            return sum;
        }

        private static void Main()
        {
            Console.WriteLine("** SUM RETURNER **");
            Console.WriteLine("Enter First Number");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Second Number");
            int b = int.Parse(Console.ReadLine());
            int result = Sum(a, b);
            Console.WriteLine("The sum is {0}", result);
            Console.ReadLine();
        }
    }
}