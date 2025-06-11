using System;
using System.Collections.Generic;



namespace PokemonGame
{
    class Program
    {
        static void Main(string[] args)
        {
            // 🔥 Attacker
            var flamethrower = new Attack("Flamethrower", ElementType.Fire, 12);
            var ember = new Attack("Ember", ElementType.Fire, 6);

            var waterGun = new Attack("Water Gun", ElementType.Water, 10);
            var bubble = new Attack("Bubble", ElementType.Water, 5);

            var thunderbolt = new Attack("Thunderbolt", ElementType.Electric, 13);
            var spark = new Attack("Spark", ElementType.Electric, 7);

            // 🐉 Skapa Pokémon
            var charmander = new Charmander(5, new List<Attack> { flamethrower, ember });
            var squirtle = new Squirtle(4, new List<Attack> { waterGun, bubble });
            var pikachu = new Pikachu(15, new List<Attack> { thunderbolt, spark });

            // 👥 Samla i lista
            List<Pokemon> team = new List<Pokemon> { charmander, squirtle, pikachu };

            foreach (var pokemon in team)
            {
                // 🆙 Höj level
                pokemon.RaiseLevel();

                // ⚡ Använd en attack
                pokemon.Attack();

                // 🌟 Om Pokémon är evolvable → utveckla!
                if (pokemon is IEvolvable evolvable)
                {
                    evolvable.Evolve();
                }

                Console.WriteLine();
            }

            Console.WriteLine("Träningen är klar! Tryck på valfri knapp för att avsluta.");
            Console.ReadKey();
        }
    }
}