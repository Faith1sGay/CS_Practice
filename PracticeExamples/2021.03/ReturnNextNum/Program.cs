using System;
namespace ReturnNextNum
{
    class Program
    {
        public static int Addition(int x)
        {
            return x + 1;
        }
        static void Main()
        {
            Console.WriteLine("Enter the number you want to know the next value that comes after : ");
            var input = int.Parse(Console.ReadLine());
            var res = Addition(input);
            Console.WriteLine("The next number that comes after {0} is {1}", input, res);
            Console.ReadLine();
        }
    }
}