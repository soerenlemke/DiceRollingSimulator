namespace DiceRollingSimulator.Models;

public class GameStatistics
{
    public Dictionary<int, int> NumbersThrown { get; set; } = new Dictionary<int, int>();
    
    public void GetNumbersThrown()
    {
        
    }

    public void CreateNumbersThrown(int numberOfSidesPerDice)
    {
        for (int i = 1; i <= numberOfSidesPerDice; i++)
        {
            NumbersThrown.Add(i, 0);
        }
    }
}