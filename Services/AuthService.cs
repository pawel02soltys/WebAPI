using WebAPI.Data;
using WebAPI.DTOs;

namespace WebAPI.Services
{
    public class AuthService
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
