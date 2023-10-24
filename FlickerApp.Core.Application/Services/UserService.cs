using FlickerApp.Core.Application.Interfaces.Repositories;
using FlickerApp.Core.Application.Interfaces.Services;
using FlickerApp.Core.Application.ViewModels.User;
using FlickerApp.Core.Domain.Entities;


namespace FlickerApp.Core.Application.Services
{
    public class UserService : IGenericService<SaveUserViewModel, UserViewModel>
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task Update(SaveUserViewModel viewModel)
        {
            User user = MapSaveUserViewModelToUser(viewModel);
            await _userRepository.UpdateAsync(user);
        }

        public async Task Add(SaveUserViewModel viewModel)
        {
            User user = MapSaveUserViewModelToUser(viewModel);
            await _userRepository.AddAsync(user);
        }

        public async Task Delete(int userId)
        {
            var user = await _userRepository.GetByIdAsync(userId);
            if (user != null)
            {
                await _userRepository.DeleteAsync(user);
            }
        }

        public async Task<SaveUserViewModel> GetByIdSaveViewModel(int userId)
        {
            var user = await _userRepository.GetByIdAsync(userId);

            if (user != null)
            {
                return MapUserToSaveUserViewModel(user);
            }
            return null;
        }

        public async Task<UserViewModel> GetUserByUsernameAsync(string username)
        {
            var user = await _userRepository.GetUserByUsernameAsync(username);
            return MapUserToUserViewModel(user);
        }

        public async Task<UserViewModel> ActivateUserAsync(int userId)
        {
            var user = await _userRepository.ActivateUserAsync(userId);
            return MapUserToUserViewModel(user);
        }

        public async Task<List<UserViewModel>> GetFriendsOfUserAsync(int userId)
        {
            var friends = await _userRepository.GetFriendsOfUserAsync(userId);
            return friends.Select(MapUserToUserViewModel).ToList();
        }

        public async Task<List<UserViewModel>> GetAllViewModel()
        {
            var users = await _userRepository.GetAllAsync();
            return users.Select(MapUserToUserViewModel).ToList();
        }

        private UserViewModel MapUserToUserViewModel(User user)
        {
            return new UserViewModel
            {
                UserId = user.UserId,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Phone = user.Phone,
                ProfilePicture = user.ProfilePicture,
                Email = user.Email,
                UserName = user.UserName,
                Password = user.Password,
                IsActive = user.IsActive
            };
        }
        private SaveUserViewModel MapUserToSaveUserViewModel(User user)
        {
            return new SaveUserViewModel
            {
                UserId = user.UserId,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Phone = user.Phone,
                ProfilePicture = user.ProfilePicture,
                Email = user.Email,
                UserName = user.UserName,
                Password = user.Password,
                IsActive = user.IsActive
            };
        }

        private User MapSaveUserViewModelToUser(SaveUserViewModel viewModel)
        {
            return new User
            {
                UserId = viewModel.UserId,
                FirstName = viewModel.FirstName,
                LastName = viewModel.LastName,
                Phone = viewModel.Phone,
                ProfilePicture = viewModel.ProfilePicture,
                Email = viewModel.Email,
                UserName = viewModel.UserName,
                Password = viewModel.Password,
                IsActive = viewModel.IsActive
            };
        }
    }
}
