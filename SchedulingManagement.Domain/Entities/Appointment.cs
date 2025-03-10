using SchedulingManagement.Domain.Enums;
using SchedulingManagement.Domain.Exceptions;

namespace SchedulingManagement.Domain.Entities;

public sealed class Appointment
{
    public Guid Id { get; private set; }
    public Guid CustomerId { get; private set; }
    public Guid ProviderId { get; private set; }
    public DateTime ScheduledDate { get; private set; }
    public AppointmentStatus Status { get; private set; }

    private Appointment() { }

    public Appointment(
        Guid customerId,
        Guid providerId,
        DateTime scheduledDate)
    {
        Id = Guid.NewGuid();
        CustomerId = customerId;
        ProviderId = providerId;
        ScheduledDate = scheduledDate;
        Status = AppointmentStatus.Scheduled;

        Validate();
    }

    public void Cancel()
    {
        if (Status == AppointmentStatus.Completed)
            throw new DomainException("Cannot cancel a completed appointment.");

        Status = AppointmentStatus.Canceled;
    }

    public void Complete()
    {
        if (Status != AppointmentStatus.Scheduled)
            throw new DomainException("Only scheduled appointments can be completed.");

        Status = AppointmentStatus.Completed;
    }

    private void Validate()
    {
        if (ScheduledDate < DateTime.UtcNow)
            throw new DomainException("Appointment cannot be scheduled in the past.");
    }
}

