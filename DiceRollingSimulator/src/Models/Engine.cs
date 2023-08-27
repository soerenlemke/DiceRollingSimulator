namespace DiceRollingSimulator.Models;

/// <summary>
/// Manages the game logic for the Dice Rolling Simulator.
/// Inherits from <see cref="GameStatistics"/>.
/// </summary>
public class Engine : GameStatistics
{
    private readonly Random _random = new();
    private List<Dice> _dices;
    private int _diceSides;
    private int _numberOfDices;

    /// <summary>
    /// Prints a welcome message to the console.
    /// </summary>
    public void WelcomePrint()
    {
        Console.WriteLine("___________________________________");
        Console.WriteLine("  Welcome to my DiceRollSimulator   ");
        Console.WriteLine("___________________________________");
    }

    /// <summary>
    /// Sets up the game with the specified number of dices and dice sides.
    /// </summary>
    /// <param name="numberOfDices">The number of dices to be used.</param>
    /// <param name="diceSides">The number of sides each dice should have.</param>
    public void SetupGame(int numberOfDices, int diceSides)
    {
        _numberOfDices = numberOfDices;
        _diceSides = diceSides;
    }

    /// <summary>
    /// Creates a list of <see cref="Dice"/> objects based on the game setup.
    /// </summary>
    /// <returns>A list of initialized <see cref="Dice"/> objects.</returns>
    public List<Dice> CreateDicesToPlay()
    {
        _dices = new List<Dice>();

        for (var i = 0; i < _numberOfDices; i++) _dices.Add(new Dice(_diceSides));

        return _dices;
    }

    /// <summary>
    /// Shuffles the numbers for each <see cref="Dice"/> object in a given <see cref="DiceSet"/>.
    /// Updates game statistics each time the dices are thrown.
    /// </summary>
    /// <param name="diceSet">The set of dices to be shuffled.</param>
    /// <param name="numberOfThrowsPerDice">The number of times each dice should be thrown.</param>
    public void ShuffleDices(DiceSet diceSet, int numberOfThrowsPerDice)
    {
        for (var i = 0; i < numberOfThrowsPerDice; i++)
        {
            foreach (var dice in diceSet.Dices)
            {
                dice.Number = _random.Next(1, dice.Sides + 1);

                if (NumbersThrown.ContainsKey(dice.Number))
                    NumbersThrown[dice.Number]++;
                else
                    NumbersThrown.Add(dice.Number, 1);
            }
        }
    }
}