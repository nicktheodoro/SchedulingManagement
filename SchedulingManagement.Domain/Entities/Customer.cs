using SchedulingManagement.Domain.Exceptions;
using SchedulingManagement.Domain.ValueObjects;

namespace SchedulingManagement.Domain.Entities;

public class Customer
{
    public Guid Id { get; private set; }
    public string Name { get; private set; }
    public Email Email { get; private set; }
    public PhoneNumber PhoneNumber { get; private set; }

    private Customer() { }

    public Customer(string name, Email email, PhoneNumber phoneNumber)
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
            throw new DomainException("Customer name cannot be empty.");
    }
}
