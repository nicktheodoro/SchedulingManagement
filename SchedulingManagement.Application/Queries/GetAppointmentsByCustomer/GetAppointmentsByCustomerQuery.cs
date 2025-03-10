using MediatR;
using SchedulingManagement.Domain.Entities;

namespace SchedulingManagement.Application.Queries.GetAppointmentsByCustomer;

public sealed record GetAppointmentsByCustomerQuery(Guid CustomerId) : IRequest<IEnumerable<Appointment>>;
