using System.Linq;
using ApiPokemon.Data;
using ApiPokemon.Data.Seed;
using ApiPokemon.Models;
using Microsoft.Extensions.Configuration;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.IdentityModel.Tokens;

namespace ApiPokemon.Services
{
    public class UserService
    {
        private readonly PokedexContext _context;
        private readonly IConfiguration _configuration;

        public UserService(PokedexContext context, IConfiguration configuration)
        {
            _context = context;
            _configuration = configuration;
        }

        public User? Authenticate(string username, string password)
        {
            var user = _context.Users.SingleOrDefault(u => u.Username == username && u.Password == password);
            if (user == null) return null;

            // authentication successful so generate jwt token
            var token = GenerateJwtToken(user);

            // remove password before returning
            user.Password = null;

            return user;
        }

        public User Register(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
            return user;
        }

        private string GenerateJwtToken(User user)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_configuration["Jwt:Key"]);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.Name, user.Username)
                }),
                Expires = DateTime.UtcNow.AddDays(7),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }

        public void EnsureDataSeed()
        {
            if (!_context.Users.Any())
            {
                var predefinedUsers = PredefinedUsers.Get();
                _context.Users.AddRange(predefinedUsers);
                _context.SaveChanges();
            }
        }
    }
}
