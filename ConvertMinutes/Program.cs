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
            Console.WriteLine("The amount of seconds that {0} minute(s) is : {1}", input, result);
            Console.ReadLine();
        }
    }
}