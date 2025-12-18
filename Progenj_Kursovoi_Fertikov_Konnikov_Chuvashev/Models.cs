public class Hero
{
    public string Name { get; set; }
    public Dictionary<string, double> Advantage { get; set; } = new();
    public Dictionary<string, double> Synergy { get; set; } = new();
}
