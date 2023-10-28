using FlickerApp.Core.Application.ViewModels.User;

namespace FlickerApp.Core.Application.Interfaces.Services
{
    public interface IUserService : IGenericService<SaveUserViewModel, UserViewModel>
    {
        Task<UserViewModel> GetUserByUsernameAsync(string username);
        Task<UserViewModel> ActivateUserAsync(int userId);
        Task<List<UserViewModel>> GetFriendsOfUserAsync(int userId);
        Task<List<UserViewModel>> SearchUsersAsync(string searchTerm);
    }
}
