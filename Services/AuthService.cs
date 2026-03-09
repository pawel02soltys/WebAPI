using WebAPI.Data;
using WebAPI.DTOs;

namespace WebAPI.Services
{
    public class AuthService : IAuthService
    {
        async Task CheckIfExist(RegisterDTO registerUser)
        {
            using (var ListOfUsers = new ListOfUsers())
            {
                var allData = ListOfUsers.dbUsers;
            }
        }
    }
}
