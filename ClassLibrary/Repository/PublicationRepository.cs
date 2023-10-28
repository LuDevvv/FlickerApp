using FlickerApp.Core.Application.Interfaces.Repositories;
using FlickerApp.Core.Domain.Entities;
using FlickerApp.Infrastructure.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;

namespace FlickerApp.Infrastructure.Persistence.Repository
{
    public class PublicationRepository : GenericRepository<Publication>, IPublicationRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public PublicationRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<Publication>> GetPublicationsByUserIdAsync(int userId)
        {
            return await _dbContext.Publications
                .Where(p => p.UserId == userId)
                .ToListAsync();
        }
    }
}
