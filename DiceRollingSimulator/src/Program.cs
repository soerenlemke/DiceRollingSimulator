var engine = new Engine();
engine.WelcomePrint();

Console.WriteLine("How many dices do you want to play with: ");
var numberOfDices = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("How many sides do you want the dices to have: ");
var numberOfSides = Convert.ToInt32(Console.ReadLine());

var diceSet = new DiceSet();

engine.SetupGame(numberOfDices, numberOfSides);
diceSet.Dices = engine.CreateDicesToPlay();
engine.ShuffleDices(diceSet);

foreach (var dice in diceSet.Dices) Console.WriteLine($"Dice {dice} has the number {dice.Number}");

engine.CreateNumbersThrown(numberOfSides);