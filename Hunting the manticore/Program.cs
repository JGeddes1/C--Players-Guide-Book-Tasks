//Setup Game starting state
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Numerics;
using static System.Net.Mime.MediaTypeNames;

int manticoreHealth = 10;
int cityHealth = 15;
int round = 1;

// Get the starting distance for the Manticore.
int range = AskForNumberInRange("Player 1, how far away from the city do you want to station the Manticore?", 0, 100);
Console.Clear();

Console.WriteLine("Player 2, it is your turn.");

do
{
    // Display the status for the round.
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("-----------------------------------------------------------");
    DisplayStatus(round, cityHealth, manticoreHealth);
    int damage = Damage(round);
    Console.WriteLine($"The cannon is expected to deal {damage} damage this round.");

    // Get a number from the player.
    Console.ForegroundColor = ConsoleColor.White;
    int targetRange = AskForNumber("Enter desired cannon range:");
    DisplayOverOrUnder(targetRange, range);

    if (targetRange == range)
    { manticoreHealth -= damage;
    }

    // Deal damage to the city if the Manticore is still alive.
    if (manticoreHealth > 0) cityHealth--;

    // Go on to the next round.
    round++;

} while(manticoreHealth > 0 || cityHealth < 0);


// Display the outcome of the game.
bool won = cityHealth > 0;
DisplayWinOrLose(won);

void DisplayWinOrLose(bool won)
{
    if (won)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("The Manticore has been destroyed! The city of Consolas has been saved!");
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("The city has been destroyed. The Manticore and the Uncoded One have won.");
    }
}

void DisplayOverOrUnder(int targetRange, int range)
{
    if (targetRange < range) Console.WriteLine("That round FELL SHORT of the target.");
    else if (targetRange > range) Console.WriteLine("That round OVERSHOT the target.");
    else Console.WriteLine("That round was a DIRECT HIT!");
}

int Damage(int round)
{
    if (round % 5 == 0 && round % 3 == 0) return 10;
    else if (round % 5 == 0) return 3;
    else if (round % 3 == 0) return 3;
    else return 1;

}



void DisplayStatus(int round, int cityHealth, int manticoreHealth)
{
    Console.WriteLine($"STATUS: Round: {round}  City: {cityHealth}/15  Manticore: {manticoreHealth}/10");

}






// Gets a number from the user, asking the prompt supplied by 'text'.
int AskForNumber(string text)
{
    Console.Write(text + " ");
    Console.ForegroundColor = ConsoleColor.Cyan;
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}



// Gets a number from the user and ensures it is in the given range.
int AskForNumberInRange(string text, int min, int max)
{
    while (true)
    {
        int number = AskForNumber(text);
        if (number >= min && number < max)
            return number;
    }


}