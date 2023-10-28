using FlickerApp.Core.Application.Interfaces.Services;
using FlickerApp.Core.Application.ViewModels.Publication;

namespace FlickerApp.Core.Application.Interfaces.Services
{
    public interface IPublicationService : IGenericService<SavePublicationViewModel, PublicationViewModel>
    {
        Task<List<PublicationViewModel>> GetPublicationsByUserIdAsync(int userId);
    }
}