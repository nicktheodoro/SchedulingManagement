using SchedulingManagement.Domain.Entities;

namespace SchedulingManagement.Domain.Interfaces;

public interface IProviderRepository
{
    Task<Provider?> GetByIdAsync(Guid id);
    Task<Provider?> GetByEmailAsync(string email);
    Task AddAsync(Provider provider);
    Task UpdateAsync(Provider provider);
}
