using System;
using System.Collections.Generic;

namespace LongestSubstringLength
{
    class Program
    {
        /*public static int Substring(string x)
        {
            return new string(x.Distinct().ToArray()).Length;
        }*/
        static void Main()
        {
            Console.Write("Enter a string: ");
            string input = Console.ReadLine();
            Dictionary<char, int> counts = new Dictionary<char, int>();

            foreach (char i in input)
            {
                if (!counts.ContainsKey(i))
                {
                    counts[i] = 1;
                }
                else
                {
                    counts[i] += 1;
                }
            }

            foreach (KeyValuePair<char, int> kvp in counts)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }
        }
    }
}