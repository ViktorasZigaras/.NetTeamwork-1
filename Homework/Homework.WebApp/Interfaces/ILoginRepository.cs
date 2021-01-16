using System.Collections.Generic;
using System.Threading.Tasks;
using Homework.WebApp.Models;

namespace Homework.WebApp.Interfaces
{
    public interface ILoginRepository
    {
        Task LoginAsync(User user);

        Task LogOutAsync(User user); // int id
    }
}