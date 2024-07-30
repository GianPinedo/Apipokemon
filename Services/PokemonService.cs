using System.Collections.Generic;
using System.Linq;
using ApiPokemon.Data;
using ApiPokemon.Data.Seed;
using ApiPokemon.Models;

namespace ApiPokemon.Services
{
    public class PokemonService
    {
        private readonly PokedexContext _context;

        public PokemonService(PokedexContext context)
        {
            _context = context;
        }

        public List<Pokemon> GetPokemons(string? type = null, string? ability = null, string? gender = null)
        {
            var query = _context.Pokemons.AsQueryable();

            if (!string.IsNullOrEmpty(type))
                query = query.Where(p => p.Type.Contains(type));

            if (!string.IsNullOrEmpty(ability))
                query = query.Where(p => p.Abilities.Contains(ability));

            if (!string.IsNullOrEmpty(gender))
                query = query.Where(p => p.Gender == gender);

            return query.ToList();
        }

        public Pokemon AddPokemon(Pokemon pokemon)
        {
            _context.Pokemons.Add(pokemon);
            _context.SaveChanges();
            return pokemon;
        }

        public void EnsureDataSeed()
        {
            if (!_context.Pokemons.Any())
            {
                var predefinedPokemons = PredefinedPokemons.Get();
                _context.Pokemons.AddRange(predefinedPokemons);
                _context.SaveChanges();
            }
        }
    }
}
