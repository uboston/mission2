namespace Mission2;

public class Rolls
{
    public int[] SimulateRolls(int rollNum)
    {
        Random rnd = new Random();
        List<int> totals = new List<int>();
        
        for (int i = 0; i < rollNum; i++)
        {
            int dice1 = rnd.Next(1, 7);
            int dice2 = rnd.Next(1, 7);
            int total = dice1 + dice2;
            totals.Add(total);
        }
        return totals.ToArray();
    }
}
