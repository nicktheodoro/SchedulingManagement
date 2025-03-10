using SchedulingManagement.Application.Interfaces;

namespace SchedulingManagement.Application.Services;

public sealed class DateTimeProvider : IDateTimeProvider
{
    public DateTime UtcNow => DateTime.UtcNow;
}
