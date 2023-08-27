namespace DiceRollingSimulator.Models;

/// <summary>
/// Represents a single dice.
/// </summary>
public class Dice
{
    private int _sides;

    /// <summary>
    /// Initializes a new instance of the <see cref="Dice"/> class.
    /// </summary>
    /// <param name="sides">The number of sides of the dice.</param>
    public Dice(int sides)
    {
        Sides = sides;
    }

    /// <summary>
    /// Gets the number of sides of the dice.
    /// Sets the number of sides to a minimum of 4 if a smaller value is provided.
    /// </summary>
    public int Sides
    {
        get => _sides;
        private set => _sides = value < 4 ? 4 : value;
    }

    /// <summary>
    /// Gets or sets the number currently shown on the dice.
    /// </summary>
    public int Number { get; set; } = 0;
}