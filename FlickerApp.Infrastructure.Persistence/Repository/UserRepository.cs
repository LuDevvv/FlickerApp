using FlickerApp.Core.Domain.Entities;
using FlickerApp.Infrastructure.Persistence.Contexts;
using FlickerApp.Core.Application.Interfaces.Repositories; // Para la interfaz IUserRepository
using FlickerApp.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks; // Para tareas asincrónicas

namespace FlickerApp.Infrastructure.Persistence.Repository
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public UserRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<User> GetUserByUsernameAsync(string username)
        {
            // Implementa la lógica para buscar un usuario por nombre de usuario
            // Por ejemplo, usando Entity Framework:
            return await _dbContext.Users.SingleOrDefaultAsync(u => u.Username == username);
        }
    }

}
