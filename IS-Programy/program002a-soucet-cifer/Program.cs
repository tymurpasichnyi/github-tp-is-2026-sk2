// Řídicí proměnná pro opakování programu
string again = "a";

// Hlavní smyčka programu
while (again.ToLower() == "a")
{
    Console.Clear();
    Console.WriteLine("***********************************");
    Console.WriteLine("***** Ciferný součet a součin *****");
    Console.WriteLine("******* Matematické řešení ********");
    Console.WriteLine("***********************************\n");

    // 1. Bezpečné načtení celého čísla
    Console.Write("Zadejte celé číslo: ");
    int number;
    while (!int.TryParse(Console.ReadLine(), out number))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte celé číslo znovu: ");
    }

    // 2. Příprava proměnných
    int numberBackup = number;
    int sum = 0;
    int product = 1; // Neutrální prvek pro násobení je 1
    int digit;

    // 3. Ošetření záporných čísel
    if (number < 0)
    {
        number = -number;
    }

    // 4. Zvláštní případ pro nulu
    if (number == 0)
    {
        sum = 0;
        product = 0; // Pokud je číslo 0, součin je také 0
    }
    else
    {
        Console.WriteLine("\nPrůběh rozkladu čísla na cifry (zprava doleva):");

        // 5. Matematický rozklad čísla
        while (number > 0)
        {
            digit = number % 10;            
            
            sum = sum + digit;              
            product = product * digit;      // Vynásobení aktuální cifrou

            Console.WriteLine($"Získána cifra: {digit}");

            number = number / 10;           
        }
    }

    // 6. Výpis výsledků
    Console.WriteLine("\n====================================");
    Console.WriteLine($"Původní číslo:  {numberBackup}");
    Console.WriteLine($"Ciferný součet: {sum}");
    Console.WriteLine($"Ciferný součin: {product}");
    Console.WriteLine("====================================\n");

    // 7. Dotaz na opakování programu
    Console.Write("Pro opakování programu stiskněte 'a' a potvrďte klávesou Enter: ");
    again = Console.ReadLine() ?? "";
}