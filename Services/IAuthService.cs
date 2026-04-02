using WebAPI.Models;

namespace WebAPI.Services
{
    public interface IAuthService
    {
        IEnumerable<Car> Get();
        IEnumerable<User> GetUser();
        Task PutUser();
    }
}
