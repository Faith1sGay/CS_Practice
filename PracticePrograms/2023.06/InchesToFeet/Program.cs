namespace InchesToFeet
{
    internal class Program
    {
        private static void Main()
        {
            Console.WriteLine("Enter the total amount of inches: ");
            if (int.TryParse(Console.ReadLine(), out int totalInches))
            {
                int feet = 0, remainingInches = 0;
                InchesToFeetConverter(totalInches, ref feet, ref remainingInches);
                Console.WriteLine($"{feet}' {remainingInches}\"");
            }
            else
            {
                Console.WriteLine("Invalid input. Please try again.");
            }
        }

        private static void InchesToFeetConverter(int inches, ref int feet, ref int remainingInches)
        {
            feet = inches / 12;
            remainingInches = inches % 12;
        }
    }
}