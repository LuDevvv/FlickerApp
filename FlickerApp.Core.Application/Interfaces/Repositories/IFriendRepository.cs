using FlickerApp.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlickerApp.Core.Application.Interfaces.Repositories
{
    public interface IFriendRepository : IGenericRepository<Friend>
    {
        Task<List<Friend>> GetFriendsByUserIdAsync(int userId);
    }
}
