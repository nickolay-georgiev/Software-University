using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DefiningClasses
{
    public class Trainer
    {
        public Trainer(string name, List<Pokemon> pokemons)
        {
            Name = name;
            Pokemons = pokemons;
            NumberOfBadges = 0;
        }

        public Trainer(string name, int numberOfBadges, List<Pokemon> pokemons)
        {
            Name = name;
            NumberOfBadges = numberOfBadges;
            Pokemons = pokemons;
        }

        public string Name { get; set; }

        public int NumberOfBadges { get; set; }

        public List<Pokemon> Pokemons { get; set; }

        public static void PokemonAttack(List<Trainer> trainers, string command)
        {
            foreach (var trainer in trainers)
            {
                if (trainer.Pokemons.Any(x => x.Element == command))
                {
                    trainer.NumberOfBadges += 1;
                }
                else
                {
                    int index = -1;
                    foreach (var pokemon in trainer.Pokemons)
                    {
                        pokemon.Health -= 10;

                        if (pokemon.Health <= 0)
                        {
                            index = trainer.Pokemons.IndexOf(pokemon);
                        }
                    }

                    if (index != -1)
                    {
                        trainer.Pokemons.RemoveAt(index);
                    }
                }
            }
        }
    }
}
