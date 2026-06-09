// Set player and monster health at start
int heroHealth = 10;
int monsterHealth = 10;

// Create a randomizer for the attack power each turn
Random random = new Random();
int attackPower = random.Next(1, 11);

// set a boolean to switch after each turn
bool heroTurn = true;


// Gameplay loop



while (monsterHealth > 0 && heroHealth > 0)
{
    if (heroTurn == true)
    {
        // Simulate hero attack and print the results
        monsterHealth -= attackPower;
        Console.WriteLine($"Monster was damaged and lost {attackPower} health and now has {monsterHealth} health.");
        heroTurn = false;
    }
    else
    {
        // Simulate monster attack and print the results
        heroHealth -= attackPower;
        Console.WriteLine($"Hero was damaged and lost {attackPower} health and now has {heroHealth} health.");
        heroTurn = true;
    }
}

if (monsterHealth <= 0)
{
    Console.WriteLine("Hero wins!");
}
else
{
    Console.WriteLine("Monster wins!");
}








