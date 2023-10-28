using FlickerApp.Core.Application.Interfaces.Repositories;
using FlickerApp.Core.Domain.Entities;
using FlickerApp.Infrastructure.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;

namespace FlickerApp.Infrastructure.Persistence.Repository
{
    public class CommentRepository : GenericRepository<Comment>, ICommentRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public CommentRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<Comment>> GetCommentsByPublicationIdAsync(int publicationId)
        {
            return await _dbContext.Comments
                .Where(c => c.PublicationId == publicationId)
                .ToListAsync();
        }
    }
}
