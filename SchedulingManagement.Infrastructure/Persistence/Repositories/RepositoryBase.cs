using Microsoft.EntityFrameworkCore;
using SchedulingManagement.Infrastructure.Persistence.Context;

namespace SchedulingManagement.Infrastructure.Persistence.Repositories;

public abstract class RepositoryBase<T>(ApplicationDbContext context) 
    : IRepository<T> where T : class
{
    private readonly DbSet<T> _dbSet = context.Set<T>();

    public virtual async Task<T?> GetByIdAsync(Guid id) => await _dbSet.FindAsync(id);
    public virtual async Task AddAsync(T entity) => await _dbSet.AddAsync(entity);
    public virtual async Task AddAsync(IEnumerable<T> entity) => await _dbSet.AddRangeAsync(entity);
    public void Udpate(T entity) => _dbSet.Update(entity);
    public void Udpate(IEnumerable<T> entity) => _dbSet.UpdateRange(entity);
    public void Delete(T entity) => _dbSet.Remove(entity);
    public void Delete(IEnumerable<T> entity) => _dbSet.RemoveRange(entity);

    public async Task Commit() => await context.SaveChangesAsync();
}
