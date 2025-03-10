using MediatR;
using SchedulingManagement.Domain.Entities;
using SchedulingManagement.Domain.Interfaces;

namespace SchedulingManagement.Application.Commands.CreateAppointment;

public sealed record CreateAppointmentHandler(IAppointmentRepository AppointmentRepository) 
    : IRequestHandler<CreateAppointmentCommand, Guid>
{
    public async Task<Guid> Handle(
        CreateAppointmentCommand request,
        CancellationToken cancellationToken)
    {
        var appointment = new Appointment(request.CustomerId,
                                          request.ProviderId,
                                          request.ScheduledDate);

        await AppointmentRepository.AddAsync(appointment);
        return appointment.Id;
    }
}
