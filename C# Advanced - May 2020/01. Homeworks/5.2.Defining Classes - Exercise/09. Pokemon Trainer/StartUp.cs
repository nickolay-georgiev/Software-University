using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Trainer> trainers = new List<Trainer>();
            List<Pokemon> pokemons = new List<Pokemon>();

            while (true)
            {
                string command = Console.ReadLine();

                if (command.Equals("Tournament"))
                {
                    break;
                }

                string[] input = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string trainerName = input[0];
                string pokemonName = input[1];
                string pokemonElement = input[2];
                int pokemonHealth = int.Parse(input[3]);

                if (trainers.Any(x => x.Name.Equals(trainerName)))
                {
                    Trainer tempTrainer = trainers.FirstOrDefault(x => x.Name == trainerName);
                    int index = trainers.IndexOf(tempTrainer);
                    trainers[index].Pokemons.Add(new Pokemon(pokemonName, pokemonElement, pokemonHealth));
                    continue;

                }

                trainers.Add(new Trainer(trainerName, new List<Pokemon>()));
                trainers[trainers.Count - 1].Pokemons.Add(new Pokemon(pokemonName, pokemonElement, pokemonHealth));
            }

            while (true)
            {
                string command = Console.ReadLine();

                if (command.Equals("End"))
                {
                    break;
                }

                if (command.Equals("Fire"))
                {
                    Trainer.PokemonAttack(trainers, command);
                }
                else if (command.Equals("Water"))
                {
                    Trainer.PokemonAttack(trainers, command);
                }
                else if (command.Equals("Electricity"))
                {
                    Trainer.PokemonAttack(trainers, command);
                }
            }

            foreach (var trainer in trainers.OrderByDescending(x => x.NumberOfBadges))
            {
                Console.WriteLine($"{trainer.Name} {trainer.NumberOfBadges} {trainer.Pokemons.Count()}");
            }
        }
    }
}
