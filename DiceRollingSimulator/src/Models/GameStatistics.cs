namespace DiceRollingSimulator.Models;

/// <summary>
/// Manages the game statistics for the Dice Rolling Simulator.
/// </summary>
public class GameStatistics
{
    /// <summary>
    /// Gets or sets the dictionary that stores the numbers thrown and their counts.
    /// </summary>
    public Dictionary<int, int> NumbersThrown { get; set; } = new Dictionary<int, int>();

    /// <summary>
    /// Creates a record for each possible number that can be thrown by the dice.
    /// Initializes the counts to zero.
    /// </summary>
    /// <param name="numberOfSidesPerDice">The number of sides each dice has.</param>
    public void CreateNumbersThatCanBeThrown(int numberOfSidesPerDice)
    {
        for (var i = 1; i <= numberOfSidesPerDice; i++) NumbersThrown.Add(i, 0);
    }

    /// <summary>
    /// Prints the numbers thrown so far and their counts.
    /// </summary>
    public void PrintNumbersThrown()
    {
        Console.WriteLine("Numbers thrown and their counts:");
        foreach (var entry in NumbersThrown)
        {
            Console.WriteLine($"Number: {entry.Key}, Count: {entry.Value}");
        }
    }
}