using Microsoft.EntityFrameworkCore;
using FlickerApp.Core.Domain.Entities;
using FlickerApp.Infrastructure.Persistence.Contexts;
using FlickerApp.Core.Application.Interfaces.Repositories;
using FlickerApp.Infrastructure.Persistence.Repository;

namespace FlickerApp.Infrastructure.Persistence.Repositories
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public UserRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<User> GetUserByUsernameAsync(string username)
        {
            return await _dbContext.Users.SingleOrDefaultAsync(u => u.UserName == username);
        }

        public async Task<User> ActivateUserAsync(int userId)
        {
            var user = await GetByIdAsync(userId);
            if (user != null)
            {
                user.IsActive = true;
                await UpdateAsync(user);
            }
            return user;
        }

        public async Task<List<User>> GetFriendsOfUserAsync(int userId)
        {
            return await _dbContext.Users
                .Where(u => u.Friends.Any(f => f.UserId == userId))
                .ToListAsync();
        }

        public async Task<List<User>> SearchUsersAsync(string searchTerm)
        {
            return await _dbContext.Users
                .Where(u => u.UserName.Contains(searchTerm) || u.FirstName.Contains(searchTerm) || u.LastName.Contains(searchTerm))
                .ToListAsync();
        }
    }
}
