using E_Commerce.Domain.Entities;

namespace E_Commerce.Domain.Contracts;

public interface IRepository<TEntity, Tkey>
    where TEntity : Entity<Tkey>
{
    public void Add(TEntity entity);
    public void Remove(TEntity entity); 
    public void Update(TEntity entity);
    Task<TEntity?> GetByIdAsync(Tkey id, CancellationToken cancellationToken = default);
    Task<IEnumerable<TEntity>> GetAllAsync(CancellationToken cancellationToken = default);
}
