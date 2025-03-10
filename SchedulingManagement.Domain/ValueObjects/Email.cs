using System;
using SchedulingManagement.Domain.Exceptions;

namespace SchedulingManagement.Domain.ValueObjects;

public class Email
{
    public string Address { get; private set; }

    private Email() { }

    public Email(string address)
    {
        if (string.IsNullOrWhiteSpace(address) || !address.Contains("@"))
            throw new DomainException("Invalid email format.");

        Address = address;
    }

    public override string ToString() => Address;
}
