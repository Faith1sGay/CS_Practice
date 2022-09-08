using System;

namespace StringRepeater
{
    internal class Program
    {
        private static void Main()
        {
            Console.WriteLine("What is the string you would like to be repeated?");
            Console.WriteLine(StringTimes(Console.ReadLine(), 4000));
        }

        private static string StringTimes(string s, uint n)
        {
            string res = "";
            for (int i = 0; i < n; i++)
            {
                res += s;
            }
            return res;
        }
    }
}