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
        Task<List<Account>> GetAll();
        Task Topup(int id, decimal topup);
        Task Delete(int id);
    }
}
