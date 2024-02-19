namespace DefiningClasses
{
    public class StartUp
    {
        static void Main()
        {
            string input;
            List<Trainer> trainers = new ();
            while ((input = Console.ReadLine()) != "Tournament") 
            {
                string[] pokemonArgs = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string trainerName = pokemonArgs[0];
                string pokemonName = pokemonArgs[1];
                string pokemonElement = pokemonArgs[2];
                int pokemonHealth = int.Parse(pokemonArgs[3]);
                Pokemon pokemon = new Pokemon(pokemonName, pokemonElement, pokemonHealth);
                
                Trainer foundTrainer = trainers.FirstOrDefault(t => t.Name == trainerName);
                if (foundTrainer != null)
                {
                    foundTrainer.Pokemons.Add(pokemon);
                }
                else
                {
                    Trainer newTrainer = new Trainer(trainerName);
                    newTrainer.Pokemons.Add(pokemon);
                    trainers.Add(newTrainer);
                }              
            }
            while ((input = Console.ReadLine()) != "End")
            {
                for (int i = 0; i < trainers.Count; i++)
                {
                    if (!trainers[i].Pokemons.Any(p => p.Element == input))
                    {
                        foreach(Pokemon pokemon in trainers[i].Pokemons)
                        {
                            pokemon.Health -= 10;
                        }
                    }
                    else
                    {
                        trainers[i].Badges += 1;
                    }
                    trainers[i].Pokemons.RemoveAll(p => p.Health <= 0);                 
                }
            }
          
            List<Trainer> orderedTrainers = trainers.OrderByDescending(t => t.Badges).ToList();
            foreach (Trainer trainer in orderedTrainers)
            {
                Console.WriteLine($"{trainer.Name} {trainer.Badges} {trainer.Pokemons.Count}");
            }
        }
    }
}