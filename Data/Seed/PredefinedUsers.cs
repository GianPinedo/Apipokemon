using System.Collections.Generic;
using ApiPokemon.Models;

namespace ApiPokemon.Data.Seed
{
    public static class PredefinedUsers
    {
        public static List<User> Get()
        {
            return new List<User>
            {
                new User { Username = "user1", Password = "123" },
                new User { Username = "user2", Password = "password2" },
                new User { Username = "admin", Password = "adminpass" },
            };
        }
    }
}
