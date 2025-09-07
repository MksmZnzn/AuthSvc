using AuthSvc.Domain.Entities;

namespace AuthSvc.Domain.Interfaces;

public interface IRoleRepository : IBaseRepository<Role>
{
    Task<List<Role>> GetRolesAsync(List<Guid> roleIds);
}