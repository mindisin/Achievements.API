using Microsoft.EntityFrameworkCore;
using Domain.Entities;

namespace Application.Interfaces
{
    /// <summary>
    /// Интерфейс БД контекста
    /// </summary>
    public interface IAppDbContext
    {
        public DbSet<User> Users { get; set; }

        public DbSet<Achievement> Achievements { get; set; }

        public DbSet<Award> Awards { get; set; }

        public DbSet<Competition> Competitions { get; set; }

        public DbSet<Role> Roles { get; set; }

      
        /// <summary>
        /// Сохранение изменений в бд
        /// </summary>
        /// <param name="token"></param>
        /// <returns>Task<int></returns>
        Task<int> SaveChangesAsync(CancellationToken token);
    }
}
