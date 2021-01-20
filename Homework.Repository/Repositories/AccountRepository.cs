using Homework.WebApp.Data;
using System.Collections.Generic;
using System.Linq;
using Homework.Domain.Interfaces;
using Homework.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Homework.WebApp.Repositories
{
    public class AccountRepository : IAccountRepository
    {
        private readonly DataContext _context;

        public AccountRepository(DataContext context)
        {
            _context = context;
        }
        public List<Account> GetAll()
        {
            return _context.Accounts.Include(c => c.User).ToList();
        }
        public void Topup(Topup model)
        {
            foreach (var value in _context.Accounts)
            {
                if (value.Id == model.Id)
                {
                    value.Balance += model.Balance;
                }
            }
            _context.SaveChanges();
        }
        public void Delete(int id)
        {
            var account = _context.Accounts.Where(i => i.Id == id).SingleOrDefault();
            _context.Accounts.Remove(account);
            _context.SaveChanges();
        }
        public List<User> GetAllUsers()
        {
            return _context.Users.ToList();
        }
        public void AddAccount(Account account)
        {
            _context.Accounts.Add(account);
            _context.SaveChanges();
        }

    }
}
