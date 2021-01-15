using System.Collections.Generic;
using System.Threading.Tasks;
using Homework.WebApp.Models;

namespace Homework.WebApp.Interfaces
{
    public interface IUserRepository
    {
        Task<List<User>> GetAllIUsersAsync();
        
        Task<User> GetUserAsync(int id);

        Task AddUserAsync(User user);

        Task EditUserAsync(User user);
        
        Task DeleteUserAsync(int id);
    }
}