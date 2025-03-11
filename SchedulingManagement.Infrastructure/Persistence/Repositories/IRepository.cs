using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SchedulingManagement.Infrastructure.Persistence.Repositories;

public interface IRepository<T> where T : class
{
    Task<T?> GetByIdAsync(Guid id);
    Task AddAsync(T entity);
    Task AddAsync(IEnumerable<T> entity);
    void Udpate(T entity);
    void Udpate(IEnumerable<T> entity);
    void Delete(T entity);
    void Delete(IEnumerable<T> entity);
    Task Commit();
}
