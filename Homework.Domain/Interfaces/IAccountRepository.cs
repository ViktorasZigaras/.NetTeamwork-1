using System.Collections.Generic;
using Homework.Domain.Models;

namespace Homework.Domain.Interfaces
{
    public interface IAccountRepository
    {
        List<Account> GetAll();
        void Topup(int id, decimal topup);
        void Delete(int id);
    }
}
