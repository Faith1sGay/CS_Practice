using System;

namespace NextLicensePlateNumber
{
    internal class Program
    {
        private static void Main()
        {
            Console.Write("Enter the current license plate number: ");
            string? currentPlate = Console.ReadLine();
            string? nextPlate = GenerateNextLicensePlateNumber(currentPlate);
            Console.WriteLine("Next license plate number: " + nextPlate);
        }

        private static string? GenerateNextLicensePlateNumber(string? currentPlateNumber)
        {
            if (string.IsNullOrEmpty(currentPlateNumber))
            {
                return "AAA000";
            }
            char[] nextPlate = currentPlateNumber.ToCharArray();
            bool carry = true;
            for (int i = nextPlate.Length - 1; i >= 0; i--)
            {
                if (carry)
                {
                    if (nextPlate[i] == '9')
                    {
                        nextPlate[i] = '0';
                    }
                    else if (nextPlate[i] == 'Z')
                    {
                        nextPlate[i] = 'A';
                    }
                    else
                    {
                        nextPlate[i]++;
                        carry = false;
                    }
                }
            }
            if (carry)
            {
                return "AAA000";
            }
            return new string(nextPlate);
        }
    }
}