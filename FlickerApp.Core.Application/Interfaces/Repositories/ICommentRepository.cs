using FlickerApp.Core.Domain.Entities;

namespace FlickerApp.Core.Application.Interfaces.Repositories
{
    public interface ICommentRepository : IGenericRepository<Comment>
    {
        Task<List<Comment>> GetCommentsByPublicationIdAsync(int publicationId);
    }
}
