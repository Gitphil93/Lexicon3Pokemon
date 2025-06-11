using System;
using System.Collections.Generic;
using PokemonGame;

public abstract class Pokemon
{
    private string _name;
    private int _level;

    public string Name
    {
        get => _name;
        set
        {
            if (value.Length < 2 || value.Length > 15)
                throw new ArgumentException("Name must be 2–15 characters.");
            _name = value;
        }
    }

    public int Level
    {
        get => _level;
        set
        {
            if (value < 1)
                throw new ArgumentException("Level must be ≥ 1.");
            _level = value;
        }
    }

    public ElementType Type { get; protected set; }
    public List<Attack> Attacks { get; }

    public Pokemon(string name, int level, List<Attack> attacks)
    {
        Name = name;
        Level = level;
        Attacks = attacks ?? new List<Attack>();
    }

    public void RandomAttack()
    {
        if (Attacks.Count == 0) return;
        var rand = new Random();
        int index = rand.Next(Attacks.Count);
        Attacks[index].Use(Level);
    }

    public void Attack()
    {
        Console.WriteLine($"{Name}'s Attacks:");
        for (int i = 0; i < Attacks.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {Attacks[i].Name} ({Attacks[i].Type})");
        }

        Console.Write("Välj attacknummer: ");
        if (int.TryParse(Console.ReadLine(), out int choice) && choice >= 1 && choice <= Attacks.Count)
        {
            Attacks[choice - 1].Use(Level);
        }
        else
        {
            Console.WriteLine("Ogiltigt val.");
        }
    }

    public void RaiseLevel()
    {
        Level++;
        Console.WriteLine($"{Name} leveled up to {Level}!");
    }
}
