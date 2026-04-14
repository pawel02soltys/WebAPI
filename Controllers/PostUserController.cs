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

        [HttpGet]
        public ActionResult Get()
        {
            if (_authService.GetUser(2) == 2)
            {
                return Ok(new { message = "Użytkownik o ID 2 istnieje." });
            }
            else
            {
                return NotFound(new { message = "Użytkownik o ID 2 nie istnieje." });
            }
        }

        [HttpPost]
        public ActionResult Post()
        {
            if (Get() is OkObjectResult okResult)
            {
                return Ok(new { message = "Użytkownik o ID 2 istnieje." });
            }
            else
            {
                return NotFound(new { message = "Użytkownik o ID 2 nie istnieje." });
            }
        }
    }
}
