namespace ElvesFoodInventory
{
    internal class Program
    {
        private static void Main()
        {
#if DEBUG
            string input = File.ReadAllText(Path.GetFileName("Calories.txt"));
#else
            string input = File.ReadAllText(Path.GetFileName("../../../Calories.txt"));
#endif
            string[] lines = input.Split('\n', StringSplitOptions.RemoveEmptyEntries);

            List<int> calories = new();

            int maxCalories = 0;

            foreach (string line in lines)
            {
                if (string.IsNullOrWhiteSpace(line))
                {
                    if (calories.Count > 0)
                    {
                        int currentCalories = calories.Sum();
                        if (currentCalories > maxCalories)
                        {
                            maxCalories = currentCalories;
                        }
                        calories.Clear();
                    }
                }
                else
                {
                    calories.Add(int.Parse(line));
                }
            }

            if (calories.Count > 0)
            {
                int currentCalories = calories.Sum();
                if (currentCalories > maxCalories)
                {
                    maxCalories = currentCalories;
                }
            }

            Console.WriteLine("Total Calories carried by the Elf with the most Calories: " + maxCalories);
        }
    }
}