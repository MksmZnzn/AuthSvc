namespace AuthSvc.Domain.Security;

public static class Configuration
{
    public static SecretConfiguration Secrets { get; set; } = new ();
    public class SecretConfiguration
    {
        public string ApiKey { get; set; } =
            Environment.GetEnvironmentVariable("SECRET_API_KEY") 
            ?? throw new Exception("Api Key is missing");
        public string JwtPrivateKey { get; set; } = 
            Environment.GetEnvironmentVariable("SECRET_JWT_PRIVATE_KEY") 
            ?? throw new Exception("JWT Private Key is missing");
        public string PasswordSaltKey { get; set; } = 
            Environment.GetEnvironmentVariable("SECRET_JWT_PASSWORD_SALT")
            ?? throw new Exception("JWT Password Salt Key is missing");
    }
}