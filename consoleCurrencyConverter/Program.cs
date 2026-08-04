// Currency values
decimal usd = 1.0m;
decimal ars = 1522.0m;
decimal eur = 0.87m;
decimal jpy = 157.71m;
decimal gbp = 0.74m;

int exchangeCurrency;

// Ask for exchange currency
Console.WriteLine("Please select the currency you want to exchange: \n1. Dollar (USD)\n2. Peso (ARS)\n3. Euro (EUR)\n4. Yen (JPY)\n5. British Pound (GBP)");
string? input = Console.ReadLine();
while(!int.TryParse(input, out exchangeCurrency) || exchangeCurrency < 1 || exchangeCurrency >5)
{
    Console.WriteLine("Not a valid option, please select a valid option: \n1. Dollar (USD)\n2. Peso (ARS)\n3. Euro (EUR)\n4. Yen (JPY)\n5. British Pound (GBP)");
    input = Console.ReadLine();
}

// debug (check if input is printing OK)
Console.WriteLine(exchangeCurrency);