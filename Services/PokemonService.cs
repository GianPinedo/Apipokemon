using System;
using System.Collections.Generic;
using System.Linq;
using ApiPokemon.Data;
using ApiPokemon.Data.Seed;
using ApiPokemon.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

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
            //TODO: Implementar la lógica para obtener los Pokemons con filtros
            try
            {
                //get all pokemons from the database
                return _context.Pokemons.ToList();

                /*
                var query = _context.Pokemons.AsQueryable();

                if (!string.IsNullOrEmpty(type))
                    query = query.Where(p => p.Type.Contains(type));

                if (!string.IsNullOrEmpty(ability))
                    query = query.Where(p => p.Abilities.Contains(ability));

                if (!string.IsNullOrEmpty(gender))
                    query = query.Where(p => p.Gender == gender);

                return query.ToList();
                */
            }
            catch (Exception ex) when (ex is SqlException || ex is DbUpdateException)
            {
                // Si hay un error de conexión,
                // devolver los datos predefinidos aplicando los filtros, se debe tener en cuenta
                // que si los parametros tiene como valor "0" no se aplicara el filtro
                //return PredefinedPokemons.Get();
                //return void list
                return new List<Pokemon>();
            }
        }

        public Pokemon AddPokemon(Pokemon pokemon)
        {
            try
            {
                _context.Pokemons.Add(pokemon);
                _context.SaveChanges();
                return pokemon;
            }
            catch (Exception ex) when (ex is SqlException || ex is DbUpdateException)
            {
                // Si hay un error de conexión, simplemente devolver null o manejar el error según sea necesario
                return null;
            }
        }

        public void EnsureDataSeed()
        {
            try
            {
                if (!_context.Pokemons.Any())
                {
                    var predefinedPokemons = PredefinedPokemons.Get();
                    _context.Pokemons.AddRange(predefinedPokemons);
                    _context.SaveChanges();
                }
            }
            catch (Exception ex) when (ex is SqlException || ex is DbUpdateException)
            {
                // Manejar el error si ocurre durante la siembra de datos
            }
        }
    }
}
