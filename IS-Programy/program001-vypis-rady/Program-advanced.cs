using System;

class Program
{
    static void Main()
    {
        Console.Write("Zadej start (first): ");
        int first = int.Parse(Console.ReadLine());

        Console.Write("Zadej konec (last): ");
        int last = int.Parse(Console.ReadLine());

        Console.Write("Zadej krok (step): ");
        int step = int.Parse(Console.ReadLine());

        int soucet = 0;
        int pocet = 0;

        Console.WriteLine("\nVýsledná řada:");
        for (int i = first; i <= last; i += step)
        {
            Console.WriteLine(i);
            soucet += i; // Přičítáme číslo k celkovému součtu
            pocet++;     // Počítáme celkový počet prvků
        }

        // Statistiky navíc (nadstavba)
        Console.WriteLine("\n--- Statistika ---");
        Console.WriteLine($"Počet čísel v řadě: {pocet}");
        Console.WriteLine($"Součet všech čísel: {soucet}");
    }
}