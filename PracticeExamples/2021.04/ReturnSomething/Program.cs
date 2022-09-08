using System;

namespace ReturnSomething
{
    internal class Program
    {
        private static string ReturnSomething(string x)
        {
            return "Something " + x;
        }

        private static void Main()
        {
            var x = ReturnSomething(Console.ReadLine());
            Console.WriteLine(x);
        }
    }
}