// Ask for first input
Console.WriteLine("Please input first number:");
string? input = Console.ReadLine();
int num1;
while (!int.TryParse(input, out num1))
{
    Console.WriteLine("Not a valid number, input another");
    input = Console.ReadLine();
}
;

// Ask for operator
Console.WriteLine("Please input operator:");
input = Console.ReadLine();
string operatorSign;
while (input != "+" && input != "-" && input != "/" && input != "*")
{
    Console.WriteLine("Wrong operator, please input +, -, / or *:");
    input = Console.ReadLine();
}
operatorSign = input;
;

// Ask for second input
Console.WriteLine("Please input second number:");
input = Console.ReadLine();
int num2;
while (!int.TryParse(input, out num2))
{
    Console.WriteLine("Not a valid number, input another");
    input = Console.ReadLine();
}
;

// Calculate result
int result;
switch (operatorSign)
{
    case "+":
        result = num1 + num2;
        break;
    case "-":
        result = num1 - num2;
        break;
    case "/":
        result = num1 / num2;
        break;
    case "*":
        result = num1 * num2;
        break;
    default:
        throw new Exception("Invalid operator");
}

Console.WriteLine($"Result is {result}");
