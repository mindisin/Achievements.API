using Domain.Entities;

namespace Application.Interfaces
{
    public interface IUsersPepository
    {
        public Task Add(User user, CancellationToken cancellationToken);
        public Task<User> GetByEmail(string email, CancellationToken cancellationToken);
    }
}
