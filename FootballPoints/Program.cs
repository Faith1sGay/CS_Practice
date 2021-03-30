using System;
namespace FootballPoints
{
    class Program
    {
        static int FootballPoints(int x, int y, int z)
        {
            return x * 3 + y * 1 + z * 0;
        }
        static void Main()
        {
            int a, b, c, res;
            Console.WriteLine("**Football points calculator**");
            Console.WriteLine("Enter how many points you want to calculate (example: 3, ");
            Console.WriteLine("Enter the amount of wins the football team has : ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the amount of draws the football team has : ");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the amount of loses the football team has : ");
            c = int.Parse(Console.ReadLine());
            res = FootballPoints(a, b, c);
            Console.WriteLine("Points Breakdown:\nWins: {0}\nDraws: {1}\nLoses: {2}\nResulting Points: {3}", a, b, c, res);
            Console.ReadLine();
        }
    }
}