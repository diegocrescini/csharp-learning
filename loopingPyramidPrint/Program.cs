
int spaces = 4;
int asterisks = 1;
for (int row = 0; row < 5; row++) // for rows 0-4
{

    for (int i  = spaces; i > 0; i--) // for 
    {
        Console.Write(" ");
        
    }
    for (int j = 0; j < asterisks; j ++)
    {
        Console.Write("*");
        
    }
    
    spaces--;
    asterisks+=2;
    Console.WriteLine();
}


