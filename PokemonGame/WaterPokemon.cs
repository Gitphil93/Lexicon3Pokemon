
using System.Collections.Generic;

namespace PokemonGame
{
public class WaterPokemon : Pokemon
{
    public WaterPokemon(string name, int level, List<Attack> attacks)
        : base(name, level, attacks)
    {
        Type = ElementType.Water;
    }
}
}