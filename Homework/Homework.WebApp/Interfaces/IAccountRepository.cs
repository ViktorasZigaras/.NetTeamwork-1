using System.Collections.Generic;
using Homework.WebApp.Models;

namespace Homework.WebApp.Interfaces
{
    public interface IAccountRepository
    {
        List<Account> GetAll();
        void Topup(int id, decimal topup);
        void Delete(int id);
    }
}
