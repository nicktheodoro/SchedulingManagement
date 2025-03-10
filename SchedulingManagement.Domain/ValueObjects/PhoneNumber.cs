using System;
using SchedulingManagement.Domain.Exceptions;

namespace SchedulingManagement.Domain.ValueObjects;

public sealed class PhoneNumber
{
    public string Number { get; private set; }

    private PhoneNumber() { }

    public PhoneNumber(string number)
    {
        if (string.IsNullOrWhiteSpace(number) || number.Length < 10)
            throw new DomainException("Invalid phone number.");

        Number = number;
    }

    public override string ToString() => Number;
}
