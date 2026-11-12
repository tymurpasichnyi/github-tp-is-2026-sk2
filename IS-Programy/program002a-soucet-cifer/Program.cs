// Řídicí proměnná pro opakování programu
string again = "a";

<<<<<<< HEAD
// Hlavní smyčka programu: běží znovu, pokud uživatel zadá 'a' nebo 'A'
while (again.ToLower() == "a")
{
    Console.Clear();
    Console.WriteLine("***************************************");
    Console.WriteLine("*********** Ciferný součet ************");
    Console.WriteLine("***************************************");
    Console.WriteLine("*********** Tymur Pasichnyi ***********");
    Console.WriteLine("***************************************");
    Console.WriteLine();

    // 1. Bezpečné načtení celého čísla od uživatele
=======
// Hlavní smyčka programu
while (again.ToLower() == "a")
{
    Console.Clear();
    Console.WriteLine("***********************************");
    Console.WriteLine("***** Ciferný součet a součin *****");
    Console.WriteLine("******* Matematické řešení ********");
    Console.WriteLine("***********************************\n");

    // 1. Bezpečné načtení celého čísla
>>>>>>> 4f42d659a8a6a7ccacc225e0d4fc1be0a6c1732f
    Console.Write("Zadejte celé číslo: ");
    int number;
    while (!int.TryParse(Console.ReadLine(), out number))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte celé číslo znovu: ");
    }

<<<<<<< HEAD
    // 2. Příprava pomocných proměnných pro výpočet
    int numberBackup = number; // Záloha původního čísla pro závěrečný výpis
    int sum = 0;               // Neutrální prvek pro sčítání je 0
    int digit;                 // Proměnná pro uložení právě oddělené cifry

    // 3. Ošetření záporných čísel (znaménko nemá vliv na cifry)
=======
    // 2. Příprava proměnných
    int numberBackup = number;
    int sum = 0;
    int product = 1; // Neutrální prvek pro násobení je 1
    int digit;

    // 3. Ošetření záporných čísel
>>>>>>> 4f42d659a8a6a7ccacc225e0d4fc1be0a6c1732f
    if (number < 0)
    {
        number = -number;
    }

    // 4. Zvláštní případ pro nulu
    if (number == 0)
    {
        sum = 0;
<<<<<<< HEAD
    }
    else
    {
        Console.WriteLine();
        Console.WriteLine("Průběh rozkladu čísla na cifry (zprava doleva):");

        // 5. Matematický rozklad čísla pomocí cyklu
        while (number > 0)
        {
            digit = number % 10;            // Modulo 10 získá poslední číslici
            sum = sum + digit;              // Přičtení cifry k celkovému součtu

            Console.WriteLine($"Získána cifra: {digit}");

            number = number / 10;           // Celočíselné dělení 10 odstraní poslední číslici
=======
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
>>>>>>> 4f42d659a8a6a7ccacc225e0d4fc1be0a6c1732f
        }
    }

    // 6. Výpis výsledků
<<<<<<< HEAD
    Console.WriteLine();
    Console.WriteLine("====================================");
    Console.WriteLine($"Původní číslo:  {numberBackup}");
    Console.WriteLine($"Ciferný součet: {sum}");
    Console.WriteLine("====================================");
    Console.WriteLine();
=======
    Console.WriteLine("\n====================================");
    Console.WriteLine($"Původní číslo:  {numberBackup}");
    Console.WriteLine($"Ciferný součet: {sum}");
    Console.WriteLine($"Ciferný součin: {product}");
    Console.WriteLine("====================================\n");
>>>>>>> 4f42d659a8a6a7ccacc225e0d4fc1be0a6c1732f

    // 7. Dotaz na opakování programu
    Console.Write("Pro opakování programu stiskněte 'a' a potvrďte klávesou Enter: ");
    again = Console.ReadLine() ?? "";
}