namespace Demo.JWT.Auth.API
{
    public interface IJwtAuthenticationManager
    {
        string Authenticate(string username, string password);
    }
}
