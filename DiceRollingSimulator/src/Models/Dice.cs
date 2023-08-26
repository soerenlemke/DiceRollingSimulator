namespace DiceRollingSimulator.Models;

public class Dice
{
    private int _sides;

    public Dice(int sides)
    {
        Sides = sides;
    }

    public int Sides
    {
        get => _sides;
        private set => _sides = value < 4 ? 4 : value;
    }

    public int Number { get; set; } = 0;
}