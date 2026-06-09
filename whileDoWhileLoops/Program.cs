/*
Code project 1 - write code that validates integer input
Here are the conditions that your first coding project must implement:

Your solution must include either a do-while or while iteration.

Before the iteration block: your solution must use a Console.WriteLine() statement to prompt the user for an integer value between 5 and 10.

Inside the iteration block:

Your solution must use a Console.ReadLine() statement to obtain input from the user.
Your solution must ensure that the input is a valid representation of an integer.
If the integer value isn't between 5 and 10, your code must use a Console.WriteLine() statement to prompt the user for an integer value between 5 and 10.
Your solution must ensure that the integer value is between 5 and 10 before exiting the iteration.
Below (after) the iteration code block: your solution must use a Console.WriteLine() statement to inform the user that their input value has been accepted.
*/

int userInputInt = 0;
bool validEntry = false;
Console.WriteLine("Type in a number between 5 and 10");
while (validEntry == false)
    {
        string? userInput = Console.ReadLine();
        if(int.TryParse(userInput, out userInputInt))
        {
            
            if (userInputInt >= 5 && userInputInt <= 10)
            {
                validEntry = true;
            }
            else Console.WriteLine($"Your number is {userInputInt}. Type in a number between 5 and 10");
            
        }  
        else Console.WriteLine("Sorry, you entered an invalid number, please try again.");
    } 
    


Console.WriteLine($"Your input {userInputInt} has been accepted.");


/*
Code project 2 - write code that validates string input
Here are the conditions that your second coding project must implement:

Your solution must include either a do-while or while iteration.

Before the iteration block: your solution must use a Console.WriteLine() statement to prompt the user for one of three role names: Administrator, Manager, or User.

Inside the iteration block:

Your solution must use a Console.ReadLine() statement to obtain input from the user.
Your solution must ensure that the value entered matches one of the three role options.
Your solution should use the Trim() method on the input value to ignore leading and trailing space characters.
Your solution should use the ToLower() method on the input value to ignore case.
If the value entered isn't a match for one of the role options, your code must use a Console.WriteLine() statement to prompt the user for a valid entry.
Below (after) the iteration code block: Your solution must use a Console.WriteLine() statement to inform the user that their input value has been accepted.
*/

Console.WriteLine("Select role (Administrator, Manager or User)");
string roleInput = "";
bool validRole = false;

while (!validRole)
{
    roleInput = Console.ReadLine().Trim().ToLower();
    if (roleInput != "administrator" && roleInput != "manager" && roleInput != "user")
    {
        Console.WriteLine($"{roleInput} is not a valid role. Please input a valid role.");        
    } else
    {
        validRole = true;
    }
    
}   


    Console.WriteLine($"Your {roleInput} role has been accepted. Welcome, {roleInput}.");