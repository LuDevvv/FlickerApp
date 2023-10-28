using AutoMapper;
using FlickerApp.Core.Application.Interfaces.Repositories;
using FlickerApp.Core.Application.Interfaces.Services;
using FlickerApp.Core.Application.ViewModels.User;
using FlickerApp.Core.Domain.Entities;

namespace FlickerApp.Core.Application.Services
{
    public class UserService : IGenericService<SaveUserViewModel, UserViewModel>
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;

        public UserService(IUserRepository userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }

        public async Task Update(SaveUserViewModel viewModel)
        {
            User user = _mapper.Map<User>(viewModel);
            await _userRepository.UpdateAsync(user);
        }

        public async Task Add(SaveUserViewModel viewModel)
        {
            User user = _mapper.Map<User>(viewModel);
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
                return _mapper.Map<SaveUserViewModel>(user);
            }
            return null;
        }

        public async Task<UserViewModel> GetUserByUsernameAsync(string username)
        {
            var user = await _userRepository.GetUserByUsernameAsync(username);
            return _mapper.Map<UserViewModel>(user);
        }

        public async Task<UserViewModel> ActivateUserAsync(int userId)
        {
            var user = await _userRepository.ActivateUserAsync(userId);
            return _mapper.Map<UserViewModel>(user);
        }

        public async Task<List<UserViewModel>> GetFriendsOfUserAsync(int userId)
        {
            var friends = await _userRepository.GetFriendsOfUserAsync(userId);
            return _mapper.Map<List<UserViewModel>>(friends);
        }

        public async Task<List<UserViewModel>> GetAllViewModel()
        {
            var users = await _userRepository.GetAllAsync();
            return _mapper.Map<List<UserViewModel>>(users);
        }
    }
}
