namespace WebAPI.Models
{
    public class User
    {
        int Id { get; set; }
        string UserName { get; set; }
        string PasswordHash { get; set; }
    }
}
