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

        [HttpPost]
        // Zmieniłem zwracany typ na Task<IActionResult>, co jest dobrą praktyką dla metod POST, 
        // które zazwyczaj nie zwracają listy wszystkich użytkowników.
        public async Task<IActionResult> PostUser()
        {
            // Wywołanie logiki z serwisu
            await _authService.PostUser();

            // Zwrócenie statusu 200 OK po pomyślnym dodaniu użytkownika
            return Ok(new { message = "Pomyślnie dodano użytkownika admin." });
        }
    }
}
