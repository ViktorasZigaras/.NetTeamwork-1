using Homework.WebApp.Data;
using Homework.WebApp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Homework.WebApp.Repositories
{
    public class AccountRepository : IAccountRepository
    {
        private readonly DataContext _context;

        public AccountRepository(DataContext context)
        {
            _context = context;
        }
        public async Task<List<Account>> GetAll()
        {
            return await _context.Accounts.OrderBy(x => x.Id).ToListAsync();
        }
        public async Task Topup(int id, decimal topup)
        {
            foreach (var value in _context.Accounts)
            {
                if (value.Id == id)
                {
                    value.Balance += topup;
                }
            }
            await _context.SaveChangesAsync();
        }
        public async Task AddAccount(Account account)
        {
            _context.Accounts.Add(account);
            await _context.SaveChangesAsync();
        }
        public async Task Delete(int id)
        {
            var account = _context.Accounts.Where(i => i.Id == id).SingleOrDefault();
            _context.Accounts.Remove(account);
            await _context.SaveChangesAsync();
        }
    }
}
