namespace Mission2;

public class Rolls
{
    public int[] SimulateRolls(int rollNum)
    {
        // Import random
        Random rnd = new Random();
        
        // Initiate list
        List<int> totals = new List<int>();
        
        // Roll based on rollNum parameter
        for (int i = 0; i < rollNum; i++)
        {
            // Roll both dice and sum
            int dice1 = rnd.Next(1, 7);
            int dice2 = rnd.Next(1, 7);
            int total = dice1 + dice2;
            totals.Add(total);
        }
        // Return the array
        return totals.ToArray();
    }
}
