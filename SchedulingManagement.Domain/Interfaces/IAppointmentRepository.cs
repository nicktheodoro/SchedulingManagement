using System;
using SchedulingManagement.Domain.Entities;

namespace SchedulingManagement.Domain.Interfaces;

public interface IAppointmentRepository
{
    Task<Appointment?> GetByIdAsync(Guid id);
    Task<IEnumerable<Appointment>> GetByCustomerIdAsync(Guid customerId);
    Task<IEnumerable<Appointment>> GetByProviderIdAsync(Guid providerId);
    Task AddAsync(Appointment appointment);
    Task UpdateAsync(Appointment appointment);
}
