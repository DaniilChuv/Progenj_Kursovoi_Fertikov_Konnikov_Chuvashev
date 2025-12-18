public class HeroRepository
{
    private readonly Dictionary<string, Hero> _heroes = new();

    public void AddHero(Hero hero) => _heroes[hero.Name] = hero;
    public IEnumerable<Hero> All => _heroes.Values;
}