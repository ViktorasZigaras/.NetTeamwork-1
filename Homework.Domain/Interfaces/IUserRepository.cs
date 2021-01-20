using System.Collections.Generic;
using System.Threading.Tasks;
using Homework.Domain.Models;

namespace Homework.Domain.Interfaces
{
    public interface IUserRepository
    {
        Task<List<User>> GetAllUsersAsync();
        
        Task<User> GetUserAsync(int id);

        Task AddUserAsync(User user);

        Task EditUserAsync(User user);
        
        Task DeleteUserAsync(int id);
    }
}