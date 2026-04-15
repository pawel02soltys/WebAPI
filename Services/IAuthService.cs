using WebAPI.Models;

namespace WebAPI.Services
{
    public interface IAuthService
    {
        IEnumerable<Car> Get();
        int GetUser(int id);
        bool UsernameExists(string username);
        User CreateUser(User newUser);
    }
}
