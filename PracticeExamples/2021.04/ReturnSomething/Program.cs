using System;

namespace ReturnSomething
{
    class Program
    {
        static string ReturnSomething(string x)
        {
            return "Something " + x;
        }
        static void Main()
        {
           var x =  ReturnSomething(Console.ReadLine());
            Console.WriteLine(x);
        }
    }
}