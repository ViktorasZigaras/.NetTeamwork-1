using Homework.WebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework.WebApp.Repositories
{
    public interface IAccountRepository
    {
        List<Account> GetAll();
        void Topup(int id, decimal topup);
        void Delete(int id);
    }
}
