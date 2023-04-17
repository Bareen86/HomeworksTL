using Hotels.Infrastucture.Foundation;
using Microsoft.EntityFrameworkCore;
using Hotels.Infrastructure;
using Microsoft.Extensions.DependencyInjection;
using Hotels.Application;

var builder = WebApplication.CreateBuilder(args);


// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var connectionString = builder.Configuration.GetConnectionString("Hotels");
builder.Services.AddDbContext<HotelsDbContext>(options => options.UseSqlServer(connectionString));
builder.Services.AddInfrastructure();
builder.Services.AddAplication();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
