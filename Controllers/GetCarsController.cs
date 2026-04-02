using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Data;
using WebAPI.Models;
using WebAPI.Services;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GetCarsController : ControllerBase
    {
        private readonly IAuthService _authService;

        public GetCarsController(IAuthService authService)
        {
            _authService = authService;
        }

        [HttpGet(Name = "PostLogin")]
        public IEnumerable<Car> Get()
        {
            return _authService.Get();
        }
    }
}
        
    

