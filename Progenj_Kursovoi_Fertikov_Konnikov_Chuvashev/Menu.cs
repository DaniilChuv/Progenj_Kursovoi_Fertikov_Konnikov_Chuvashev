public static class ConsoleUI
{
    public static void DrawScreen(
        List<Hero> available,
        List<string> enemies,
        List<string> allies,
        List<string> bans)
    {
        Console.Clear();
        Console.WriteLine("░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░");
        Console.WriteLine(" СИСТЕМА АНТИПИК Betta 0.001 DEMO");
        Console.WriteLine("░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░");
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("========================================");
        Console.WriteLine(" ДОСТУПНЫЕ ГЕРОИ");
        Console.WriteLine("========================================");

        for (int i = 0; i < available.Count; i++)
        {
            Console.Write($"[{i + 1}] {available[i].Name,-18}");
            if ((i + 1) % 3 == 0) Console.WriteLine();
        }
        Console.WriteLine("\n");

        Console.WriteLine("----------------------------------------");
        Console.WriteLine($" ВРАГИ:    {(enemies.Count == 0 ? "-" : string.Join(", ", enemies))}");
        Console.WriteLine($" СОЮЗНИКИ: {(allies.Count == 0 ? "-" : string.Join(", ", allies))}");
        Console.WriteLine($" БАНЫ:     {(bans.Count == 0 ? "-" : string.Join(", ", bans))}");
        Console.WriteLine("----------------------------------------");

        Console.WriteLine("1 - добавить ВРАГА");
        Console.WriteLine("2 - добавить СОЮЗНИКА");
        Console.WriteLine("3 - забанить героя");
        Console.WriteLine("4 - показать рекомендации пика");
        Console.WriteLine("5 - показать рекомендации бана");
        Console.WriteLine("6 - Перейти к рекомендациям по ходу игры");
        Console.WriteLine("0 - выход");
    }

    public static int AskHeroIndex(int max)
    {
        Console.Write("\nВведите номер героя: ");
        if (int.TryParse(Console.ReadLine(), out int index))
            if (index >= 1 && index <= max)
                return index - 1;

        return -1;
    }

    public static void ShowRecommendations(Dictionary<string, double> scores)
    {
        Console.Clear();
        Console.WriteLine("========================================");
        Console.WriteLine(" РЕКОМЕНДАЦИИ ПИКА");
        Console.WriteLine("========================================");

        foreach (var kv in scores.Take(7))
            Console.WriteLine($"{kv.Key,-20} score = {kv.Value}");

        Console.WriteLine("\nНажмите любую клавишу...");
        Console.ReadKey();
    }
}
