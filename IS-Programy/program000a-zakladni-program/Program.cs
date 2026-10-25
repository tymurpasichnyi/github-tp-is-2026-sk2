using System;

class Program
{
    static void Main()
    {
        Console.Write("Zadej číslo: ");
        int cislo = int.Parse(Console.ReadLine());

        Console.WriteLine($"Zadal jsi: {cislo}");
    }
}