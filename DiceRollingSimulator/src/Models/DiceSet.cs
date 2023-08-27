namespace DiceRollingSimulator.Models;

/// <summary>
/// Represents a collection of <see cref="Dice"/> objects.
/// </summary>
public class DiceSet
{
    /// <summary>
    /// Gets or sets the list of <see cref="Dice"/> objects that make up this set.
    /// </summary>
    public List<Dice> Dices = new List<Dice>();
}