using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Homework.Domain.Interfaces;
using Homework.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Homework.WebApp.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly DbContext _context;

        public UserRepository(DbContext context)
        {
            _context = context;
        }
        
        public async Task<List<User>> GetAllIUsersAsync()
        {
            var users = await _context.Set<User>().ToListAsync();
            foreach (var user in users)
            {
                var accounts = _context.Set<Account>().Where(u => u.UserId == u.Id).ToList();
                user.Accounts = accounts;
            }
            return users;
        }

        public async Task<User> GetUserAsync(int id)
        {
            return await _context.Set<User>().FindAsync(id);
        }

        public async Task AddUserAsync(User user)
        {
            _context.Set<User>().Add(user);
            await _context.SaveChangesAsync();
        }

        public async Task EditUserAsync(User user)
        {
            _context.Update(user);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteUserAsync(int id)
        {
            var user = await GetUserAsync(id);
            _context.Set<User>().Remove(user);
            await _context.SaveChangesAsync();
        }
    }
}