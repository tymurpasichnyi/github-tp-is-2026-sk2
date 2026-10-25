using System;

class Program
{
    static void Main()
    {
        // 1. Získání čísel od uživatele
        Console.Write("Zadej start (first): ");
        int first = int.Parse(Console.ReadLine());

        Console.Write("Zadej konec (last): ");
        int last = int.Parse(Console.ReadLine());

        Console.Write("Zadej krok (step): ");
        int step = int.Parse(Console.ReadLine());

        // 2. Počítadlo a výpis
        Console.WriteLine("\nVýsledek:");
        for (int i = first; i <= last; i += step)
        {
            Console.WriteLine(i);
        }
    }
}