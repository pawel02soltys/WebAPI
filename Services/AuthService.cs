using WebAPI.Data;
using WebAPI.DTOs;
using Microsoft.EntityFrameworkCore;
using WebAPI.Models;

namespace WebAPI.Services
{
    public class AuthService : IAuthService
    {
        Car newCar = new Car() { Id = 1, UserName = "user1" , PasswordHash = "123"};
        public string Get()
        {
            string respond = "GBO";
            return respond;
        }
    }
}
