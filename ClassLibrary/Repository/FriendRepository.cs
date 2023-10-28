using FlickerApp.Core.Application.Interfaces.Repositories;
using FlickerApp.Core.Domain.Entities;
using FlickerApp.Infrastructure.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;

namespace FlickerApp.Infrastructure.Persistence.Repository
{
    public class FriendRepository : GenericRepository<Friend>, IFriendRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public FriendRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<Friend>> GetFriendsByUserIdAsync(int userId)
        {
            return await _dbContext.Friends
                .Where(f => f.UserId == userId)
                .ToListAsync();
        }
    }
}
