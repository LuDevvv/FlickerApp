using FlickerApp.Core.Application.ViewModels.Friend;

namespace FlickerApp.Core.Application.Interfaces.Services
{
    public interface IFriendService : IGenericService<SaveFriendViewModel, FriendViewModel>
    {
        Task<List<FriendViewModel>> GetFriendsByUserIdAsync(int userId);
    }
}
