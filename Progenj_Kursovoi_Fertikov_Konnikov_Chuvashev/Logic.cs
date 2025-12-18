public class CounterPickService
{
    private readonly HeroRepository _repo;

    public CounterPickService(HeroRepository repo)
    {
        _repo = repo;
    }

    public Dictionary<string, double> CalculateScores(
        List<string> enemies,
        List<string> allies,
        List<string> bans)
    {
        var unavailable = new HashSet<string>(
            enemies.Concat(allies).Concat(bans)
        );

        var result = new Dictionary<string, double>();

        foreach (var hero in _repo.All)
        {
            if (unavailable.Contains(hero.Name))
                continue;

            double score = 0;

            foreach (var e in enemies)
                if (hero.Advantage.TryGetValue(e, out var adv))
                    score += adv;

            foreach (var a in allies)
                if (hero.Synergy.TryGetValue(a, out var syn))
                    score += syn;

            result[hero.Name] = Math.Round(score, 2);
        }

        return result
            .OrderByDescending(x => x.Value)
            .ToDictionary(x => x.Key, x => x.Value);
    }
}