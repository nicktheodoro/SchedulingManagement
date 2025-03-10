using System;
using SchedulingManagement.Domain.Exceptions;
using SchedulingManagement.Domain.ValueObjects;

namespace SchedulingManagement.Domain.Entities;

public sealed class Provider
{
    public Guid Id { get; private set; }
    public string Name { get; private set; }
    public Email Email { get; private set; }
    public PhoneNumber PhoneNumber { get; private set; }

    private Provider() { } // Necessário para EF Core

    public Provider(string name, Email email, PhoneNumber phoneNumber)
    {
        Id = Guid.NewGuid();
        Name = name;
        Email = email;
        PhoneNumber = phoneNumber;

        Validate();
    }

    private void Validate()
    {
        if (string.IsNullOrWhiteSpace(Name))
            throw new DomainException("Provider name cannot be empty.");
    }
}
