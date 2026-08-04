// Currency values
decimal usd = 1.0m;
decimal ars = 1522.0m;
decimal eur = 0.87m;
decimal jpy = 157.71m;
decimal gbp = 0.74m;

// set variables
string exchangeCurrency;
decimal exchangeAmount;
string desiredCurrency;
decimal amountReceived = 0m;

// Ask for exchange currency
Console.WriteLine("Please select the currency you want to exchange: \n1. Dollar (USD)\n2. Peso (ARS)\n3. Euro (EUR)\n4. Yen (JPY)\n5. British Pound (GBP)");
exchangeCurrency = Console.ReadLine();
while(exchangeCurrency is not("1" or "2" or "3" or "4" or "5"))
{
    Console.WriteLine("Not a valid option, please select a valid option: \n1. Dollar (USD)\n2. Peso (ARS)\n3. Euro (EUR)\n4. Yen (JPY)\n5. British Pound (GBP)");
    exchangeCurrency = Console.ReadLine();
}

// Ask for amount to exchange
Console.WriteLine("Please enter the amount you wish to convert.");
string? amountInput = Console.ReadLine();
while (!decimal.TryParse (amountInput, out exchangeAmount) || exchangeAmount <= 0)
{
    Console.WriteLine("Invalid amount. Please enter a valid number greater than 0:");
    amountInput = Console.ReadLine();
}

// Ask for exchange currency
Console.WriteLine("Please select the currency you want to recieve: \n1. Dollar (USD)\n2. Peso (ARS)\n3. Euro (EUR)\n4. Yen (JPY)\n5. British Pound (GBP)");
desiredCurrency = Console.ReadLine();
while(true)
{
    if(desiredCurrency is not("1" or "2" or "3" or "4" or "5"))
    {
        Console.WriteLine("Not a valid option, please select a valid option: \n1. Dollar (USD)\n2. Peso (ARS)\n3. Euro (EUR)\n4. Yen (JPY)\n5. British Pound (GBP)");
        desiredCurrency = Console.ReadLine();    
    } else if (desiredCurrency == exchangeCurrency)
    {
        Console.WriteLine("You can't perform an exchange on the same currency, please select a valid option: \n1. Dollar (USD)\n2. Peso (ARS)\n3. Euro (EUR)\n4. Yen (JPY)\n5. British Pound (GBP)");
        desiredCurrency = Console.ReadLine();    
    } else
    {
        break;
    }    
}

// Calculate dollar equivalent 

decimal currencyConvertedToDollar = exchangeCurrency switch
{
    "1" => exchangeAmount,
    "2" => exchangeAmount / ars,
    "3" => exchangeAmount / eur,
    "4" => exchangeAmount / jpy,
    "5" => exchangeAmount / gbp,
    _   => 0m // default
};

// Calculate other currency equivalent

decimal finalCurrency = desiredCurrency switch
{
    "1" => currencyConvertedToDollar * usd, 
    "2" => currencyConvertedToDollar * ars,
    "3" => currencyConvertedToDollar * eur,
    "4" => currencyConvertedToDollar * jpy,
    "5" => currencyConvertedToDollar * gbp,
    _   => 0m // default
};

// debug (check if inputs are saved printing OK)
Console.WriteLine($"Selected currency: {exchangeCurrency}, amount: {exchangeAmount}");
Console.WriteLine($"Final currency: {desiredCurrency}, amount: {finalCurrency:N2}");
