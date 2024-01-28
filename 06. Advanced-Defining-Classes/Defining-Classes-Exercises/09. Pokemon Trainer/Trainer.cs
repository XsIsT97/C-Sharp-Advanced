using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09._Pokemon_Trainer
{
    internal class Trainer
    {
        public string Name { get; set; }

        public int Badges
        {
            get => _badges;
            set => this._badges = 0;
        }

        public List<Pokemon> Pokemons = new List<Pokemon>();

        private int _badges;

        public Trainer(string trainer)
        {
            Name = trainer;
        }

        public void AddBadges()
        {
            _badges += 1;
        }

        public void ReduceHealth()
        {
            foreach (var pokemon in Pokemons)
            {
                pokemon.Health -= 10;
            }
        }

        public void ClearDeadPokemon()
        {
            Pokemons.RemoveAll(pokemons => pokemons.Health <= 0);
        }
    }
}
