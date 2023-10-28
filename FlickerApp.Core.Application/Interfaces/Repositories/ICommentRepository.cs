using FlickerApp.Core.Domain.Entities;

namespace FlickerApp.Core.Application.Interfaces.Repositories
{
    public interface ICommentRepository : IGenericRepository<Comment>
    {
<<<<<<< HEAD
        Task<List<Comment>> GetCommentsByPublicationIdAsync(int publicationId);
=======

>>>>>>> 708e491a411608018b724399fd2bb24f38b2de34
    }
}
