var engine = new Engine();
engine.WelcomePrint();

Console.WriteLine("How many dices do you want to play with: ");
var numberOfDices = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("How many sides do you want the dices to have: ");
var numberOfSides = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("How many throws do you want per dice: ");
var numberOfThrowsPerDice = Convert.ToInt32(Console.ReadLine());

engine.CreateNumbersThatCanBeThrown(numberOfSides);
engine.SetupGame(numberOfDices, numberOfSides);

var diceSet = new DiceSet();
diceSet.Dices = engine.CreateDicesToPlay();
engine.ShuffleDices(diceSet, numberOfThrowsPerDice);

engine.PrintNumbersThrown();