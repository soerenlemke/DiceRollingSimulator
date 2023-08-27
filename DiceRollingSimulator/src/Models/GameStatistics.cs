namespace DiceRollingSimulator.Models;

public class GameStatistics
{
    public Dictionary<int, int> NumbersThrown { get; set; } = new();

    public void GetNumbersThrown(DiceSet diceSet)
    {
        foreach (var dice in diceSet.Dices)
            if (NumbersThrown.ContainsKey(dice.Number))
                NumbersThrown[dice.Number]++;
            else
                NumbersThrown.Add(dice.Number, 1);
    }

    public void CreateNumbersThrown(int numberOfSidesPerDice)
    {
        for (var i = 1; i <= numberOfSidesPerDice; i++) NumbersThrown.Add(i, 0);
    }

    public void PrintNumbersThrown()
    {
        Console.WriteLine("Numbers thrown and their counts:");
        foreach (var entry in NumbersThrown) Console.WriteLine($"Number: {entry.Key}, Count: {entry.Value}");
    }
}