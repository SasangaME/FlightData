using AutoMapper;
using FlightData.API.Config;
using FlightData.API.Middleware;
using FlightData.Database.Context;
using FlightData.Models.Mappings;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<FlightDataContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("FlightData")));

var mapperConfig = new MapperConfiguration(
    config => { config.AddProfile(new FlightDataProfile()); });
var mappper = mapperConfig.CreateMapper();
builder.Services.AddSingleton(mappper);

builder.Services.AddExceptionHandler<ExceptionHandler>();

// Add services to the container.
builder.Services.AddDependencyServices();

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

app.UseHttpsRedirection();

app.UseExceptionHandler(opt => { });

app.UseAuthorization();

app.MapControllers();

app.Run();