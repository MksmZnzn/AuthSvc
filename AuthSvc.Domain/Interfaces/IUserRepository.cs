using AuthSvc.Domain.Entities;

namespace AuthSvc.Domain.Interfaces;

public interface IUserRepository : IBaseRepository<User>
{
    Task<User?> GetByUsernameAsync(string username, CancellationToken cancellationToken);
    Task<User?> GetByEmailAsync(string email, CancellationToken cancellationToken);
    Task<bool> AnyAsync(string email, CancellationToken cancellationToken);
}