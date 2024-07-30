using System.Collections.Generic;
using ApiPokemon.Models;

namespace ApiPokemon.Data.Seed
{
    public static class PredefinedPokemons
    {
        public static List<Pokemon> Get()
        {
            return new List<Pokemon>
            {
                new Pokemon { Name = "Pikachu", Gender = "Male", Type = "Electric", Abilities = "Static", Weight = 6.0f, Weaknesses = "Ground", ImageUrl = "https://img.pokemondb.net/artwork/pikachu.jpg" },
                new Pokemon { Name = "Charmander", Gender = "Male", Type = "Fire", Abilities = "Blaze", Weight = 8.5f, Weaknesses = "Water, Rock, Ground", ImageUrl = "https://img.pokemondb.net/artwork/charmander.jpg" },
                new Pokemon { Name = "Squirtle", Gender = "Male", Type = "Water", Abilities = "Torrent", Weight = 9.0f, Weaknesses = "Electric, Grass", ImageUrl = "https://img.pokemondb.net/artwork/squirtle.jpg" },
                new Pokemon { Name = "Bulbasaur", Gender = "Male", Type = "Grass/Poison", Abilities = "Overgrow", Weight = 6.9f, Weaknesses = "Fire, Psychic, Flying, Ice", ImageUrl = "https://img.pokemondb.net/artwork/bulbasaur.jpg" },
                new Pokemon { Name = "Jigglypuff", Gender = "Female", Type = "Normal/Fairy", Abilities = "Cute Charm", Weight = 5.5f, Weaknesses = "Steel, Poison", ImageUrl = "https://img.pokemondb.net/artwork/jigglypuff.jpg" },
                new Pokemon { Name = "Meowth", Gender = "Male", Type = "Normal", Abilities = "Pickup", Weight = 4.2f, Weaknesses = "Fighting", ImageUrl = "https://img.pokemondb.net/artwork/meowth.jpg" },
                new Pokemon { Name = "Psyduck", Gender = "Male", Type = "Water", Abilities = "Damp", Weight = 19.6f, Weaknesses = "Electric, Grass", ImageUrl = "https://img.pokemondb.net/artwork/psyduck.jpg" },
                new Pokemon { Name = "Machop", Gender = "Male", Type = "Fighting", Abilities = "Guts", Weight = 19.5f, Weaknesses = "Psychic, Flying, Fairy", ImageUrl = "https://img.pokemondb.net/artwork/machop.jpg" },
                new Pokemon { Name = "Gastly", Gender = "Male", Type = "Ghost/Poison", Abilities = "Levitate", Weight = 0.1f, Weaknesses = "Psychic, Dark, Ghost", ImageUrl = "https://img.pokemondb.net/artwork/gastly.jpg" },
                new Pokemon { Name = "Eevee", Gender = "Female", Type = "Normal", Abilities = "Run Away", Weight = 6.5f, Weaknesses = "Fighting", ImageUrl = "https://img.pokemondb.net/artwork/eevee.jpg" },
                new Pokemon { Name = "Snorlax", Gender = "Male", Type = "Normal", Abilities = "Immunity", Weight = 460.0f, Weaknesses = "Fighting", ImageUrl = "https://img.pokemondb.net/artwork/snorlax.jpg" },
                new Pokemon { Name = "Lapras", Gender = "Female", Type = "Water/Ice", Abilities = "Water Absorb", Weight = 220.0f, Weaknesses = "Electric, Grass, Fighting, Rock", ImageUrl = "https://img.pokemondb.net/artwork/lapras.jpg" },
                new Pokemon { Name = "Ditto", Gender = "Genderless", Type = "Normal", Abilities = "Limber", Weight = 4.0f, Weaknesses = "Fighting", ImageUrl = "https://img.pokemondb.net/artwork/ditto.jpg" },
                new Pokemon { Name = "Magikarp", Gender = "Male", Type = "Water", Abilities = "Swift Swim", Weight = 10.0f, Weaknesses = "Electric, Grass", ImageUrl = "https://img.pokemondb.net/artwork/magikarp.jpg" },
                new Pokemon { Name = "Gyarados", Gender = "Male", Type = "Water/Flying", Abilities = "Intimidate", Weight = 235.0f, Weaknesses = "Electric, Rock", ImageUrl = "https://img.pokemondb.net/artwork/gyarados.jpg" },
                new Pokemon { Name = "Articuno", Gender = "Genderless", Type = "Ice/Flying", Abilities = "Pressure", Weight = 55.4f, Weaknesses = "Electric, Rock, Steel, Fire", ImageUrl = "https://img.pokemondb.net/artwork/articuno.jpg" },
                new Pokemon { Name = "Zapdos", Gender = "Genderless", Type = "Electric/Flying", Abilities = "Pressure", Weight = 52.6f, Weaknesses = "Ice, Rock", ImageUrl = "https://img.pokemondb.net/artwork/zapdos.jpg" },
                new Pokemon { Name = "Moltres", Gender = "Genderless", Type = "Fire/Flying", Abilities = "Pressure", Weight = 60.0f, Weaknesses = "Electric, Rock, Water", ImageUrl = "https://img.pokemondb.net/artwork/moltres.jpg" },
                new Pokemon { Name = "Dratini", Gender = "Male", Type = "Dragon", Abilities = "Shed Skin", Weight = 3.3f, Weaknesses = "Ice, Dragon, Fairy", ImageUrl = "https://img.pokemondb.net/artwork/dratini.jpg" },
                new Pokemon { Name = "Mewtwo", Gender = "Genderless", Type = "Psychic", Abilities = "Pressure", Weight = 122.0f, Weaknesses = "Bug, Ghost, Dark", ImageUrl = "https://img.pokemondb.net/artwork/mewtwo.jpg" }
            };
        }
    }
}
