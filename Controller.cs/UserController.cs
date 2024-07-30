using Microsoft.AspNetCore.Mvc;
using ApiPokemon.Models;
using ApiPokemon.Services;

namespace ApiPokemon.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly UserService _userService;

        public UserController(UserService userService)
        {
            _userService = userService;
        }

        [HttpPost("authenticate")]
        public ActionResult Authenticate([FromBody] User user)
        {
            var authenticatedUser = _userService.Authenticate(user.Username, user.Password);
            if (authenticatedUser == null)
                return Unauthorized(new { message = "Username or password is incorrect" });

            return Ok(authenticatedUser);
        }

        [HttpPost("register")]
        public ActionResult<User> Register([FromBody] User user)
        {
            return _userService.Register(user);
        }
    }
}
