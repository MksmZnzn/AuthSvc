namespace AuthSvc.Domain.Entities;

public class User(string username, string password, string email, string number)
    : EntityBase
{
    public string Username { get; set; } = username;
    public string Password { get; set; } = password;
    public string Email { get; set; } = email;
    public string Number { get; set; } = number;
    public List<Role> Roles { get; set; } = new();
    public Guid RefreshToken { get; set; } = Guid.NewGuid();

    public void UpdateUser(User newUser)
    {
        Username = newUser.Username;
        Password = newUser.Password;
        Roles = newUser.Roles;
        Email = newUser.Email;
        Number = newUser.Number;
    }

    public void GenerateRefreshToken()
    {
        RefreshToken = Guid.NewGuid();
    }

    public void AddRole(Role role)
    {
        Roles.Add(role);
    }
}