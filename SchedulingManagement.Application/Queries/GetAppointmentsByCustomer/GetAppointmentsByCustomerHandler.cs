using MediatR;
using SchedulingManagement.Domain.Entities;
using SchedulingManagement.Domain.Interfaces;

namespace SchedulingManagement.Application.Queries.GetAppointmentsByCustomer;

public sealed class GetAppointmentsByCustomerHandler(IAppointmentRepository AppointmentRepository) 
    : IRequestHandler<GetAppointmentsByCustomerQuery, IEnumerable<Appointment>>
{
    public async Task<IEnumerable<Appointment>> Handle(
        GetAppointmentsByCustomerQuery request,
        CancellationToken cancellationToken)
    {
        return await AppointmentRepository.GetByCustomerIdAsync(request.CustomerId);
    }
}
