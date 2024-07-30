using Microsoft.EntityFrameworkCore;
using ApiPokemon.Models;

namespace ApiPokemon.Data
{
    public class PokedexContext : DbContext
    {
        public PokedexContext(DbContextOptions<PokedexContext> options) : base(options) { }

        public DbSet<Pokemon> Pokemons { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pokemon>().ToTable("Pokemon");
            modelBuilder.Entity<User>().ToTable("User");
        }
    }
}
