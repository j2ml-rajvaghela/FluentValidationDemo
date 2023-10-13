using FluentValidation.AspNetCore;
using FluentValidationDemo.API;
using FluentValidationDemo.API.Data;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add mediatr service
builder.Services.ConfigureDI();
builder.Services.AddMediatR(Assembly.GetExecutingAssembly());

// Add database service
builder.Services.AddDbContext<EmployeeContext>(opt => 
             opt.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Add services to the container.

#pragma warning disable CS0618 
builder.Services
    .AddControllers()
    .AddFluentValidation(fv =>
             fv.RegisterValidatorsFromAssemblies(AppDomain.CurrentDomain.GetAssemblies()));
#pragma warning restore CS0618 

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
