using System;

class Program
{
    static void Main()
    {
        // Vyzveme uživatele k zadání počáteční hodnoty
        Console.Write("Zadej start (first): ");
        int first = int.Parse(Console.ReadLine());

        // Vyzveme uživatele k zadání koncové hodnoty
        Console.Write("Zadej konec (last): ");
        int last = int.Parse(Console.ReadLine());

        // Vyzveme uživatele k zadání kroku (o kolik se má přičítat)
        Console.Write("Zadej krok (step): ");
        int step = int.Parse(Console.ReadLine());

        // Kontrola, aby krok nebyl 0 (předcházení zacyklení)
        if (step == 0)
        {
            Console.WriteLine("Krok nemůže být 0!");
            return;
        }

        Console.WriteLine("\nVýsledek:");
        // Cyklus začne na 'first', opakuje se dokud nedosáhne 'last' a po každém kroku přičte 'step'
        for (int i = first; i <= last; i += step)
        {
            Console.WriteLine(i);
        }
    }
}