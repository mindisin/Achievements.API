using Application.Interfaces;
using Persistence;
using Persistence.Repositories;
using Services.Services;

var builder = WebApplication.CreateBuilder(args);
var services = builder.Services;

// Add services to the container.

services.AddPersistenceLayer(builder.Configuration);
services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
services.AddEndpointsApiExplorer();
services.AddSwaggerGen();

services.AddScoped<IUsersPepository, UsersPepository>();

services.AddScoped<UserService>();

services.AddScoped<IJsonWebTokenProvider, JsonWebTokenProvider>();
services.AddScoped<IPasswordHasher, PasswordHasher>();



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
