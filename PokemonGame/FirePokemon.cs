using System.Collections.Generic;

namespace PokemonGame
{
public class FirePokemon : Pokemon
{
    public FirePokemon(string name, int level, List<Attack> attacks)
        : base(name, level, attacks)
    {
        Type = ElementType.Fire;
    }
}
}