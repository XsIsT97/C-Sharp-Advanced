using System;
using System.Collections.Generic;
using System.Linq;

namespace _09._Pokemon_Trainer
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            var trainers = GetListOfTrainers();

            PlayInTournament(trainers);

            PrintTrainers(trainers);
        }

        private static void PrintTrainers(List<Trainer> trainers)
        {
            var sorted = trainers.OrderByDescending(trainer => trainer.Badges);

            foreach (var trainer in sorted)
            {
                Console.WriteLine($"{trainer.Name} {trainer.Badges} {trainer.Pokemons.Count}");
            }
        }

        private static void PlayInTournament(List<Trainer> trainers)
        {
            string element = Console.ReadLine();

            while (element != "End")
            {
                foreach (var trainer in trainers)
                {
                    if (trainer.Pokemons.FirstOrDefault(pokemon => pokemon.Element == element) != null)
                    {
                        trainer.AddBadges();
                    }
                    else
                    {
                        trainer.ReduceHealth();
                    }
                    trainer.ClearDeadPokemon();
                }

                element = Console.ReadLine();
            }
        }

        private static List<Trainer> GetListOfTrainers()
        {
            string input = Console.ReadLine();
            List<Trainer> trainers = new List<Trainer>();

            while (input != "Tournament")
            {
                string[] trainerData = input.Split(' ');
                string trainerName = trainerData[0];

                Pokemon pokemon = new Pokemon(trainerData[1], trainerData[2], int.Parse(trainerData[3]));

                var currentTrainer = trainers.FirstOrDefault(t => t.Name == trainerName);

                if (currentTrainer != null)
                {
                    currentTrainer.Pokemons.Add(pokemon);
                }
                else
                {
                    var trainer = new Trainer(trainerName);
                    trainer.Pokemons.Add(pokemon);
                    trainers.Add(trainer);
                }

                input = Console.ReadLine();
            }

            return trainers;
        }
    }
}
