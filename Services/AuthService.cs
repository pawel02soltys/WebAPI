using WebAPI.Data;
using Microsoft.EntityFrameworkCore;
using WebAPI.Models;

namespace WebAPI.Services
{
    public class AuthService : IAuthService
    {
        public static List<User> GetDummyUsers()
        {
            return new List<User>
            {
                new User { Id = 1, Username = "jkowalski", Passwd = "Password123!" },
                new User { Id = 2, Username = "anowak", Passwd = "QwertyUIOP!9" },
                new User { Id = 3, Username = "mwisniewski", Passwd = "SuperTajneHaslo1" },
                new User { Id = 4, Username = "kwojcik", Passwd = "Admin12345@" },
                new User { Id = 5, Username = "pkaminski", Passwd = "Zima2024!#" },
                new User { Id = 6, Username = "ewojciechowska", Passwd = "MojeHaslo99$" },
                new User { Id = 7, Username = "alevandowska", Passwd = "FitnessLife12" },
                new User { Id = 8, Username = "tnowacki", Passwd = "TomekNow123" },
                new User { Id = 9, Username = "jsmith", Passwd = "JohnSmith88@" },
                new User { Id = 10, Username = "admin_glowny", Passwd = "RootPassword!00" }
            };
        }
        public IEnumerable<Car> Get()
        {
            return cars();
        }
        List<Car> cars()
        {
            using var carsDbConnection = new DbConnectionContext();
        
            return carsDbConnection.dbCars.ToList();
        }
        List<User> Users()
        {
            using var usersDbConnection = new DbConnectionContext();
        
            return usersDbConnection.dbUsers.ToList();
        }

        public int GetUser(int id)
        {
            if (Users().Any(user => user.Id == id))
            {
                return id;
            }
            else
            {
                return 0;
            }
        }   

        public User CreateUser(User newUser)
        {
            using var userDbConnection = new DbConnectionContext();
            {
                var users = userDbConnection.dbUsers.ToList();
                var newId = users.Max(u => u.Id) + 1; // Generowanie nowego ID
                newUser.Id = newId;
                userDbConnection.dbUsers.Add(newUser);
                userDbConnection.SaveChanges();
            }
            return newUser; // Zwracamy utworzonego użytkownika z przypisanym ID
        }

        public bool UsernameExists(string username)
        {
            return GetDummyUsers().Any(user => user.Username.Equals(username, StringComparison.OrdinalIgnoreCase));
        }
    }
}
