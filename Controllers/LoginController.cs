using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Models;
using WebAPI.Services;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LoginController : ControllerBase
    {
        [HttpGet(Name = "GetUser")]
        public string Get()
        { 
            User user = new User();
            user.Id = 1; user.UserName = "Test"; user.PasswordHash = "###";
            return $"{user.Id} : {user.UserName} : {user.PasswordHash} ";
        }
    }
}
        
    

