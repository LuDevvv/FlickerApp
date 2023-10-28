<<<<<<< HEAD
﻿using AutoMapper;
using FlickerApp.Core.Application.Interfaces.Repositories;
=======
﻿using FlickerApp.Core.Application.Interfaces.Repositories;
>>>>>>> 708e491a411608018b724399fd2bb24f38b2de34
using FlickerApp.Core.Application.Interfaces.Services;
using FlickerApp.Core.Application.ViewModels.User;
using FlickerApp.Core.Domain.Entities;

<<<<<<< HEAD
=======

>>>>>>> 708e491a411608018b724399fd2bb24f38b2de34
namespace FlickerApp.Core.Application.Services
{
    public class UserService : IGenericService<SaveUserViewModel, UserViewModel>
    {
        private readonly IUserRepository _userRepository;
<<<<<<< HEAD
        private readonly IMapper _mapper;

        public UserService(IUserRepository userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
=======

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
>>>>>>> 708e491a411608018b724399fd2bb24f38b2de34
        }

        public async Task Update(SaveUserViewModel viewModel)
        {
<<<<<<< HEAD
            User user = _mapper.Map<User>(viewModel);
=======
            User user = MapSaveUserViewModelToUser(viewModel);
>>>>>>> 708e491a411608018b724399fd2bb24f38b2de34
            await _userRepository.UpdateAsync(user);
        }

        public async Task Add(SaveUserViewModel viewModel)
        {
<<<<<<< HEAD
            User user = _mapper.Map<User>(viewModel);
=======
            User user = MapSaveUserViewModelToUser(viewModel);
>>>>>>> 708e491a411608018b724399fd2bb24f38b2de34
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
<<<<<<< HEAD
                return _mapper.Map<SaveUserViewModel>(user);
=======
                return MapUserToSaveUserViewModel(user);
>>>>>>> 708e491a411608018b724399fd2bb24f38b2de34
            }
            return null;
        }

        public async Task<UserViewModel> GetUserByUsernameAsync(string username)
        {
            var user = await _userRepository.GetUserByUsernameAsync(username);
<<<<<<< HEAD
            return _mapper.Map<UserViewModel>(user);
=======
            return MapUserToUserViewModel(user);
>>>>>>> 708e491a411608018b724399fd2bb24f38b2de34
        }

        public async Task<UserViewModel> ActivateUserAsync(int userId)
        {
            var user = await _userRepository.ActivateUserAsync(userId);
<<<<<<< HEAD
            return _mapper.Map<UserViewModel>(user);
=======
            return MapUserToUserViewModel(user);
>>>>>>> 708e491a411608018b724399fd2bb24f38b2de34
        }

        public async Task<List<UserViewModel>> GetFriendsOfUserAsync(int userId)
        {
            var friends = await _userRepository.GetFriendsOfUserAsync(userId);
<<<<<<< HEAD
            return _mapper.Map<List<UserViewModel>>(friends);
=======
            return friends.Select(MapUserToUserViewModel).ToList();
>>>>>>> 708e491a411608018b724399fd2bb24f38b2de34
        }

        public async Task<List<UserViewModel>> GetAllViewModel()
        {
            var users = await _userRepository.GetAllAsync();
<<<<<<< HEAD
            return _mapper.Map<List<UserViewModel>>(users);
=======
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
>>>>>>> 708e491a411608018b724399fd2bb24f38b2de34
        }
    }
}
