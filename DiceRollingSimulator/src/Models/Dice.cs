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
        private set
        {
            if (value < 4)
                _sides = 4;
            else
                _sides = value;
        }
    }

    public int Number { get; set; } = 0;
}