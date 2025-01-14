// Boston Underwood
// Section 001
// Mission 2 Assignment - Dice Roll Simulator

using Mission2;

public class Program
{
    private static void Main(string[] args)
    {
        // Welcoming to the App
        Console.WriteLine("Welcome to the dice throwing simulator!\n");
        
        // Create Instance of Class
        Rolls rolls = new Rolls();
        
        // Catch Input
        int RollNum;
        while (true)
        {
            Console.WriteLine("How many dice rolls would you like to simulate?");
            string input = Console.ReadLine();
            if (int.TryParse(input, out RollNum))
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid input. Try again.");
            }
        }
        // Make the Rolls
        int[] rollTotals = rolls.SimulateRolls(RollNum);
        
        // Present the Results
        Console.WriteLine("\nDICE ROLLING SIMULATION RESULTS");
        Console.WriteLine("Each \'*\' represents 1% of the total number of rolls.");
        Console.WriteLine("Total number of rolls = " + RollNum + ".");
        
        
        // For Loop to print the roll combination frequency
        for (int j = 2; j < 13; j++)
        {
            // Calculate the average for each roll combination 
            Console.Write($"\n{j}: ");
            for (int i = 0; i < (int)Math.Round(((double)rollTotals.Count(x => x == j) / RollNum * 100)); i++)
            {
                Console.Write("*");
            }
        }

        Console.WriteLine("\n\nThank you for using the dice throwing simulator! Goodbye!");
        
    }
}

