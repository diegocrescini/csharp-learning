using System.Globalization;
CultureInfo.CurrentCulture = new CultureInfo("en-US");

int value1 = 11;
decimal value2 = 6.2m;
float value3 = 4.3f;

int result1 = 0;
result1 = (int)Math.Round(value1 / value2);

// Hint: You need to round the result to nearest integer (don't just truncate)
Console.WriteLine($"Divide value1 by value2, display the result as an int: {result1}");

decimal result2 = 0; 
result2 = value2 / (decimal)value3;

// Your code here to set result2
Console.WriteLine($"Divide value2 by value3, display the result as a decimal: {result2}");

float result3 = 0;
result3 = (float)(value3 / value1);
// Your code here to set result3
Console.WriteLine($"Divide value3 by value1, display the result as a float: {result3}");
