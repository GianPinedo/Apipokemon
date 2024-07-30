using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using ApiPokemon.Models;
using ApiPokemon.Services;
using Microsoft.AspNetCore.Authorization;

namespace ApiPokemon.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PokemonController : ControllerBase
    {
        private readonly PokemonService _pokemonService;

        public PokemonController(PokemonService pokemonService)
        {
            _pokemonService = pokemonService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Pokemon>> GetPokemons([FromQuery] string type, [FromQuery] string ability, [FromQuery] string gender)
        {
            return _pokemonService.GetPokemons(type, ability, gender);
        }

        [HttpPost]
        [Authorize]
        public ActionResult<Pokemon> AddPokemon([FromBody] Pokemon pokemon)
        {
            return _pokemonService.AddPokemon(pokemon);
        }
    }
}
