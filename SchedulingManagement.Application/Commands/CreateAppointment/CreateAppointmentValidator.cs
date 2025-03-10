using FluentValidation;

namespace SchedulingManagement.Application.Commands.CreateAppointment;

public class CreateAppointmentValidator : AbstractValidator<CreateAppointmentCommand>
{
    public CreateAppointmentValidator()
    {
        RuleFor(x => x.CustomerId).NotEmpty().WithMessage("Customer ID is required.");
        RuleFor(x => x.ProviderId).NotEmpty().WithMessage("Provider ID is required.");
        RuleFor(x => x.ScheduledDate)
            .GreaterThan(DateTime.UtcNow).WithMessage("Scheduled date must be in the future.");
    }
}
