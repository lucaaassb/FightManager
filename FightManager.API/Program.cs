using FightManager.API.ExceptionHandler;
using FightManager.Application;
using FightManager.Application.Models;
using FightManager.Infrastructure.Persistence;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

// builder.Services.Configure<FreelanceTotalCostConfig>(
//     builder.Configuration.GetSection("FreelanceTotalCostConfig")   builder do DevFreela, ajustar depois
// );

//builder.Services.AddDbContext<FightManagerDbContext>(o => o.UseInMemoryDatabase("FightManagerDb"));
var connectionString = builder.Configuration.GetConnectionString("FightManagerCs");

builder.Services.AddDbContext<FightManagerDbContext>(o => o.UseSqlServer(connectionString));

builder.Services
    .AddApplication();

builder.Services.AddExceptionHandler<ApiExceptionHandler>();
builder.Services.AddProblemDetails();

builder.Services.AddControllers();
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

app.UseExceptionHandler();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();