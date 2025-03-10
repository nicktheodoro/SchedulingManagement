using FluentValidation;
using SchedulingManagement.Application.Interfaces;
using SchedulingManagement.Application.Services;
using SchedulingManagement.Application.Commands.CreateAppointment;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Registrar MediatR
builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(CreateAppointmentCommand).Assembly));

// Registrar FluentValidation
builder.Services.AddValidatorsFromAssembly(typeof(CreateAppointmentValidator).Assembly);

// Registrar Serviços
builder.Services.AddSingleton<IDateTimeProvider, DateTimeProvider>();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();
app.UseAuthorization();
app.MapControllers();
app.Run();
