using FlickerApp.Core.Domain.Entities;
<<<<<<< HEAD
=======
using System.Collections.Generic;
using System.Threading.Tasks;
>>>>>>> 708e491a411608018b724399fd2bb24f38b2de34

namespace FlickerApp.Core.Application.Interfaces.Repositories
{
    public interface IUserRepository : IGenericRepository<User>
    {
        Task<User> GetUserByUsernameAsync(string username);
        Task<User> ActivateUserAsync(int userId);
        Task<List<User>> GetFriendsOfUserAsync(int userId);
        Task<List<User>> SearchUsersAsync(string searchTerm);
    }
}
