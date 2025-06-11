
using System.Collections.Generic;
namespace PokemonGame
{


    public class ElectricPokemon : Pokemon
    {
        public ElectricPokemon(string name, int level, List<Attack> attacks)
            : base(name, level, attacks)
        {
            Type = ElementType.Electric;
        }
    }
}