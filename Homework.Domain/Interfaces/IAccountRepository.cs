using System.Collections.Generic;
using Homework.Domain.Models;

namespace Homework.Domain.Interfaces
{
    public interface IAccountRepository
    {
        List<Account> GetAll();
        void Topup(Topup model);
        void Delete(int id);
        List<User> GetAllUsers();
        void AddAccount(Account acount);
    }
}
