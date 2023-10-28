﻿using FlickerApp.Core.Domain.Entities;

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