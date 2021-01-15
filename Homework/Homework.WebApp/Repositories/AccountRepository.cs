using Homework.WebApp.Data;
using Homework.WebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;

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
            return _context.Accounts.OrderBy(x => x.Id).ToList();
        }
        public void Topup(int id, decimal topup)
        {
            foreach (var value in _context.Accounts)
            {
                if (value.Id == id)
                {
                    value.Balance += topup;
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
    }
}
