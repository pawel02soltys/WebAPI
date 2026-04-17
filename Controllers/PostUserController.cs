using Microsoft.AspNetCore.Mvc;
using WebAPI.Data;
using WebAPI.Models;
using WebAPI.Services;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PostUserController : ControllerBase
    {
        private readonly IAuthService _authService;

        public PostUserController(IAuthService authService)
        {
            _authService = authService;
        }

        [HttpGet("{id}/{haslo}")]
        public ActionResult Get(int id, string haslo)
        {
            return Ok(new { message = $"Object {id}" });
        }

        [HttpPost]
        public ActionResult Post([FromBody] User newUser)
        {
            if (_authService.UsernameExists(newUser.Username))
            {
                // Zwracamy status 409 Conflict - idealny do informowania o duplikatach
                return Conflict(new { message = "Ten login jest już zajęty!" });
            }

            // Krok 2: Serwis tworzy użytkownika i nadaje mu nowe ID
            var createdUser = _authService.CreateUser(newUser);

            // Krok 3: Zwracamy złoty standard 201 Created
            return CreatedAtAction(nameof(Get), new { id = createdUser.Id }, createdUser);
        }
    }
}
