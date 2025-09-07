using AuthSvc.Domain.Entities;

namespace AuthSvc.Domain.Interfaces;

public interface IBaseRepository<T> where T : EntityBase
{
    Task CreateAsync(T entity);
    Task UpdateAsync(T entity);
    Task DeleteAsync(T entity);
    T GetById(Guid id);
    List<T> GetAll();
}