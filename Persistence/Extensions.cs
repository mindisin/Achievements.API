using Common;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Application.Interfaces;
using Microsoft.EntityFrameworkCore;


namespace Persistence
{
    public static class Extensions
    {
        public static IServiceCollection AddPersistenceLayer(this IServiceCollection services, IConfiguration configuration)
        {
            IConfigurationSection section = configuration.GetSection(DbContextSettings.SectionName);
            if (section.GetSection("ConnectionString").Value == null)
            {
                throw new NullReferenceException($"There no \"{DbContextSettings.SectionName}\" section in appsettings.json");
            }

            var dbContextSettings = new DbContextSettings();
            configuration.Bind(dbContextSettings);
            services.AddDbContext<IAppDbContext, AppDbContext>(options => options.UseNpgsql(dbContextSettings.ConnectionString));
            return services;
        }
    }
}
