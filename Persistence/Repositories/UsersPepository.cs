using Application.Interfaces;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Persistence.Repositories
{
    public class UsersPepository: IUsersPepository
    {
        private readonly IAppDbContext _context;

        public UsersPepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task Add(User user, CancellationToken cancellationToken)
        {
            var userEntity = new User
            {
                Id = user.Id,
                Name = user.Name,
                Email = user.Email,
                PasswordHash = user.PasswordHash,
                Phone = user.Phone,
                CreateDate = DateTime.UtcNow,
                UpdateDate = DateTime.UtcNow,
            };

            await _context.Users.AddAsync(userEntity, cancellationToken);
            await _context.SaveChangesAsync(cancellationToken);
        }

        public async Task<User> GetByEmail(string email, CancellationToken cancellationToken)
        {
            var UserEntity = await _context.Users
                .AsNoTracking()
                .FirstOrDefaultAsync(u => u.Email == email)
                ?? throw new Exception("User with such email doesn't exist");
            // TODO: убрать исключение

            return UserEntity;
        }
    }
}
