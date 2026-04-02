using WebAPI.Data;
using Microsoft.EntityFrameworkCore;
using WebAPI.Models;

namespace WebAPI.Services
{
    public class AuthService : IAuthService
    {
        public IEnumerable<Car> Get()
        {
            return cars();
        }

        async public Task PutUser()
        {
            using var usersDbConnection = new DbConnection();
            var user = usersDbConnection.dbUsers;
            user.Add(new User
            {
                Username = "admin",
                Passwd = "admin"
            });
        }
        public IEnumerable<User> GetUser()
        {
            using var usersDbConnection = new DbConnection();
            return usersDbConnection.dbUsers
                .AsNoTracking()
                .Select(user => new User
                {
                    Id = user.Id,
                    Username = user.Username,
                    Passwd = user.Passwd,
                })
                .ToList();
        }

        List<Car> cars()
        {
            using var carsDbConnection = new DbConnection();
            return carsDbConnection.dbCars
                .AsNoTracking()
                .Select(car => new Car
                {
                    Id = car.Id,
                    Brand = car.Brand,
                    Catalog_model = car.Catalog_model,
                    Production_Year = car.Production_Year,
                })
                .ToList();
        }
    }
}
