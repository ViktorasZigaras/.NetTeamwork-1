using System.Collections.Generic;
using System.Threading.Tasks;
using Homework.WebApp.Interfaces;
using Homework.WebApp.Models;
using Microsoft.EntityFrameworkCore;

namespace Homework.WebApp.Repositories
{
    public class LoginRepository : ILoginRepository
    {
        private readonly DbContext _context;

        public LoginRepository(DbContext context)
        {
            _context = context;
        }

        public async Task LoginAsync(User user)
        {
            //
        }

        public async Task LogOutAsync(User user)
        {
            //
        }

        /*public async Task<List<User>> GetAllIUsersAsync()
        {
            return await _context.Set<User>().ToListAsync();
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
        }*/
    }
}