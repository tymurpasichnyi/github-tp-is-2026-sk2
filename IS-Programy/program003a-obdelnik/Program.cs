string again = "a";

while (again.ToLower() == "a")
{
    Console.Clear();
    Console.WriteLine("********************************");
    Console.WriteLine("***** Vykreslení obdélníku *****");
    Console.WriteLine("********************************");
    Console.WriteLine("******* Tymur Pasichnyi ********");
    Console.WriteLine("********************************");
    Console.WriteLine();

    Console.Write("Zadejte šířku obrazce (přirozené číslo): ");
    int width;
    while (!int.TryParse(Console.ReadLine(), out width) || width <= 0)
    {
        Console.Write("Šířka musí být celé kladné číslo větší než 0. Zadejte znovu: ");
    }

    Console.Write("Zadejte výšku obrazce (přirozené číslo): ");
    int height;
    while (!int.TryParse(Console.ReadLine(), out height) || height <= 0)
    {
        Console.Write("Výška musí být celé kladné číslo větší než 0. Zadejte znovu: ");
    }

    Console.WriteLine();
    Console.WriteLine($"Vykresluji obrazec o rozměrech {width} × {height}:");
    Console.WriteLine();

    for (int i = 1; i <= height; i++)
    {
        if (i % 2 == 0)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
        }

        for (int j = 1; j <= width; j++)
        {
            Console.Write("* ");
            System.Threading.Thread.Sleep(System.TimeSpan.FromMilliseconds(100));
        }

        Console.WriteLine();
    }

    Console.ResetColor();

    Console.WriteLine();
    Console.Write("Pro opakování programu stiskněte 'a' a potvrďte Enterem: ");
    again = Console.ReadLine() ?? "";
}