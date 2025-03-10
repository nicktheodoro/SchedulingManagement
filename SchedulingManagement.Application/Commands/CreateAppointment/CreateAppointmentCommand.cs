using MediatR;

namespace SchedulingManagement.Application.Commands.CreateAppointment;

public sealed record CreateAppointmentCommand : IRequest<Guid>
{
    public Guid CustomerId { get; set; }
    public Guid ProviderId { get; set; }
    public DateTime ScheduledDate { get; set; }
}
