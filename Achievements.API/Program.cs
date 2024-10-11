using Achievements.API.Endpoints;
using Application.Interfaces;
using Common.Options;
using Persistence;
using Persistence.Repositories;
using Services.Services;

var builder = WebApplication.CreateBuilder(args);
var services = builder.Services;

services.Configure<JsonWebTokenOptions>(builder.Configuration.GetSection(nameof(JsonWebTokenOptions)));

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

services.AddAuthentication("Bearer").AddJwtBearer();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapSwagger().RequireAuthorization();

app.UseAuthorization();

app.MapControllers();

app.Run();
