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

/*
int userInputInt = 0;
bool validEntry = false;
Console.WriteLine("Type in a number between 5 and 10");
while (validEntry == false)
{
    string? userInput = Console.ReadLine();
    if (int.TryParse(userInput, out userInputInt))
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
*/

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

/*
Console.WriteLine("Select role (Administrator, Manager or User)");
string roleInput = "";
bool validRole = false;

while (!validRole)
{
    roleInput = Console.ReadLine().Trim().ToLower();
    if (roleInput != "administrator" && roleInput != "manager" && roleInput != "user")
    {
        Console.WriteLine($"{roleInput} is not a valid role. Please input a valid role.");
    }
    else
    {
        validRole = true;
    }

}


Console.WriteLine($"Your {roleInput} role has been accepted. Welcome, {roleInput}.");
*/


/* Project 3
Here are the conditions that your third coding project must implement:
your solution must use the following string array to represent the input to your coding logic:
c#
string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };
Your solution must declare an integer variable named periodLocation that can be used to hold the location of the period character within a string.
Your solution must include an outer foreach or for loop that can be used to process each string element in the array. 
The string variable that you'll process inside the loops should be named myString.
In the outer loop, your solution must use the IndexOf() method of the String class to get the location 
of the first period character in the myString variable. The method call should be similar to: myString.IndexOf("."). 
If there's no period character in the string, a value of -1 will be returned.    
Your solution must include an inner do-while or while loop that can be used to process the myString variable.
In the inner loop, your solution must extract and display (write to the console) each sentence that is contained in each of the strings that are processed.
In the inner loop, your solution must not display the period character.
In the inner loop, your solution must use the Remove(), Substring(), and TrimStart() methods to process the string information.
*/



string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };

int periodLocation = 0;

foreach (string myString in myStrings)
{
    string loopString = myString;
    while (loopString.Contains("."))
    {
        periodLocation = loopString.IndexOf(".");
        Console.WriteLine(loopString.Substring(0, periodLocation));
        loopString = loopString.Remove(0, periodLocation + 1).TrimStart();
    }
    Console.WriteLine(loopString);
    
}





