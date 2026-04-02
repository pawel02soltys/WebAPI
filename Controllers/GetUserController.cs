using Microsoft.AspNetCore.Mvc;
using WebAPI.Models;
using WebAPI.Services;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GetUserController : ControllerBase
    {
        private readonly IAuthService _authService;

        public GetUserController(IAuthService authService)
        {
            _authService = authService;
        }
        [HttpPut]
         public Task PutUser()
        {
            return _authService.PutUser();
        }


        [HttpGet]
        public IEnumerable<User> GetUser()
        {
            return _authService.GetUser();
        }
    }
}
