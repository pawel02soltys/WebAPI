using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Data;
using WebAPI.DTOs;
using WebAPI.Models;
using WebAPI.Services;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GetCarsController : ControllerBase
    {
        private readonly IAuthService _authService;
        private readonly IWeatherForecastService _weatherForecastService;

        public GetCarsController(IAuthService authService, IWeatherForecastService weatherForecastService)
        {
            _authService = authService;
            _weatherForecastService = weatherForecastService;
        }

        [HttpGet(Name = "PostLogin")]
        public string Get()
        {
            return _authService.Get();
        }
    }
}
        
    

