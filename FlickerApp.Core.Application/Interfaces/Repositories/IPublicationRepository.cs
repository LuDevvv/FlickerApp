using FlickerApp.Core.Domain.Entities;

namespace FlickerApp.Core.Application.Interfaces.Repositories
{
    public interface IPublicationRepository : IGenericRepository<Publication>
    {
        Task<List<Publication>> GetPublicationsByUserIdAsync(int userId);
    }
}   
