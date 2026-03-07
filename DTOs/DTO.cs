namespace WebAPI.DTOs
{
    public struct RegisterDTO
    {
        string Username {  get; set; }
        string Password { get; set; }
        string RepeatPassword { get; set; }
    }

    public struct LoginDTO
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }

    public struct AuthDTO
    {
        string Token { get; set; }
    }
}
