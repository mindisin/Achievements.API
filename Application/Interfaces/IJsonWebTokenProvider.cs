using Domain.Entities;

namespace Application.Interfaces
{
    public interface IJsonWebTokenProvider
    {
        public string GenerateToken(User user);

        public string GenerateRefreshToken();
    }
}
