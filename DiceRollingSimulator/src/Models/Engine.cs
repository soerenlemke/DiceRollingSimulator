namespace DiceRollingSimulator.Models;

public class Engine
{
    private readonly Random _random = new();
    private List<Dice> _dices;
    private int _diceSides;
    private int _numberOfDices;

    public void WelcomePrint()
    {
        Console.WriteLine("___________________________________");
        Console.WriteLine("   Welcome to my DiceRollSimulator   ");
        Console.WriteLine("___________________________________");
    }

    public void SetupGame(int numberOfDices, int diceSides)
    {
        _numberOfDices = numberOfDices;
        _diceSides = diceSides;
    }

    public List<Dice> CreateDicesToPlay()
    {
        _dices = new List<Dice>();

        for (var i = 0; i < _numberOfDices; i++) _dices.Add(new Dice(_diceSides));

        return _dices;
    }

    public void ShuffleDices(DiceSet diceSet)
    {
        foreach (var dice in diceSet.Dices) dice.Number = _random.Next(1, dice.Sides + 1);
    }
}