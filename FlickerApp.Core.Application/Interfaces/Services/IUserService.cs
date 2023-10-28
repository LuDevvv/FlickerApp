using FlickerApp.Core.Application.ViewModels.User;
<<<<<<< HEAD
<<<<<<< HEAD
=======
using System.Collections.Generic;
using System.Threading.Tasks;
>>>>>>> 708e491a411608018b724399fd2bb24f38b2de34
=======
using System.Collections.Generic;
using System.Threading.Tasks;
>>>>>>> 708e491a411608018b724399fd2bb24f38b2de34

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
