/*
Try It Out!
Die Rolling. Tons of games use dice. The Random class gives us the ability to simulate die rolling.
Many games give the player the task of rolling multiple six-sided dice and adding up the results.
We’re going to write a program that makes life easier for the player of a game like this. Start the
program off by asking the player to type in a number of dice to roll. Create a new Random object and
use the Random.Next method to simulate that many die rolls. Add the total up and print the result
to the user. (You should only need one Random object for this.)
For bonus points, keep looping and handle new numbers until they enter “quit” or “exit.”

The program must ask user how many die to roll. 
The program must store the amount of dice rolls and their results
The program must add those results and print them to the user
The program should only use one random for this
The program must loop the whole "game" until the user types "exit" or "quit"

*/

string? userInput = "";
Random dice = new Random();
int totalRoll;
bool exitLoop = false;


do
{
    Console.WriteLine("How many die do you want to roll?");
    totalRoll = 0;
    userInput = Console.ReadLine();
    if (userInput.ToLower().Trim() == "exit" || userInput.ToLower() == "quit")
    {
        exitLoop = true;
    }
    else if (int.TryParse(userInput, out int numberOfRolls))
    {
        for (int i = 0; i < numberOfRolls; i++)
        {
            totalRoll += dice.Next(1,7);
        }
        Console.WriteLine($"The sum is: {totalRoll}");
    } else continue;

} while (exitLoop != true);