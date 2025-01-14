// See https://aka.ms/new-console-template for more information

using Mission2;

public class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the dice throwing simulator!\n");
        Rolls rolls = new Rolls();
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
        int[] rollTotals = rolls.SimulateRolls(RollNum);
        
        Console.WriteLine("\nDICE ROLLING SIMULATION RESULTS");
        Console.WriteLine("Each \'*\' represents 1% of the total number of rolls.");
        Console.WriteLine("Total number of rolls = " + RollNum + ".");
        
        for (int j = 2; j < 13; j++)
        {
            Console.Write($"\n{j}: ");
            for (int i = 0; i < (int)Math.Round(((double)rollTotals.Count(x => x == j) / RollNum * 100)); i++)
            {
                Console.Write("*");
            }
        }

        Console.WriteLine("\n\nThank you for using the dice throwing simulator! Goodbye!");
        
    }
}

