using System;
namespace FarmProblem
{
    class Program
    {
        static int Animals(int x, int y, int z)
        {
            return x * 2 + y * 4 + z * 4;
        }
        static void Main()
        {
            int a, b, c, d;
            Console.WriteLine("** Farm Animal Leg Calculator **");
            Console.WriteLine("Please Enter the amount of chickens you have : ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the amount of cows you have : ");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Please Enter the amount of pigs you have : ");
            c = int.Parse(Console.ReadLine());
            d = Animals(a, b, c);
            Console.WriteLine("Farm Animal Leg Breakdown : \nChicken legs : {0}\nCow legs : {1}\nPig Legs : {2}\nResulting amount of animal legs : {3}", a, b, c, d);
            Console.ReadLine();
        }
    }
}
