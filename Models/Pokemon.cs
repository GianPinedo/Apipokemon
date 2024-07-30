namespace ApiPokemon.Models
{
    public class Pokemon
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string Type { get; set; }
        public string Abilities { get; set; }
        public float Weight { get; set; }
        public string Weaknesses { get; set; }
        public string ImageUrl { get; set; }
    }
}
