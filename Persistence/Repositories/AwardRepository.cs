using Application.Interfaces;

namespace Persistence.Repositories
{
    public class AwardRepository
    {
        public readonly IAppDbContext _dbContext;

        public AwardRepository(IAppDbContext dbContext)
        {
            _dbContext = dbContext;
        }


    }
}
