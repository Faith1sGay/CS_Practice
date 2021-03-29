using System;
namespace ConvertMinutes
{
    class Program
    {
        public static int ConvMin(int minute)
        {
            return minute * 60;
        }
        static void Main()
        {
            Console.WriteLine("How many minute(s) would you like to convert to seconds?");
            var input = int.Parse(Console.ReadLine());
            var result = ConvMin(input);
            Console.WriteLine("The amount of seconds that amount of minute(s) is : {0}", result);
            Console.ReadLine();
        }
    }
}