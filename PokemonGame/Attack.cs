
namespace PokemonGame
{
public class Attack
{
    public string Name { get; }
    public ElementType Type { get; }
    public int BasePower { get; }

    public Attack(string name, ElementType type, int basePower)
    {
        Name = name;
        Type = type;
        BasePower = basePower;
    }

    public void Use(int level)
    {
        Console.WriteLine($"{Name} hits with total power {BasePower + level}!");
    }
}
}