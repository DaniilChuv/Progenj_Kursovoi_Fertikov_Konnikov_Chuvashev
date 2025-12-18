class Program
{
    static void Main()
    {
        var repo = DemoData.CreateRepository();
        var service = new CounterPickService(repo);

        var enemies = new List<string>();
        var allies = new List<string>();
        var bans = new List<string>();

        while (true)
        {
            var available = repo.All
                .Where(h => !enemies.Contains(h.Name)
                         && !allies.Contains(h.Name)
                         && !bans.Contains(h.Name))
                .ToList();

            ConsoleUI.DrawScreen(available, enemies, allies, bans);

            var key = Console.ReadKey(true).KeyChar;

            if (key == '0')
                break;

            if (key == '4')
            {
                var scores = service.CalculateScores(enemies, allies, bans);
                ConsoleUI.ShowRecommendations(scores);
                continue;
            }

            if (key == '5')
            {
                BanRecommendation.Show();
                continue;
            }

            if (key == '6')
            {
                MatchGameRecommendation.Show();
                continue;
            }

            if (key is '1' or '2' or '3')
            {
                if (available.Count == 0)
                    continue;

                int index = ConsoleUI.AskHeroIndex(available.Count);
                if (index == -1)
                    continue;

                var heroName = available[index].Name;

                if (key == '1') enemies.Add(heroName);
                if (key == '2') allies.Add(heroName);
                if (key == '3') bans.Add(heroName);
            }
        }
    }
}

