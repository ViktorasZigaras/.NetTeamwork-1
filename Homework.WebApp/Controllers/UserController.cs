using System.Threading.Tasks;
using Homework.Domain.Interfaces;
using Homework.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace Homework.WebApp.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserRepository _userRepository;

        public UserController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public UserController()
        {
        }

        public IActionResult Index()
        {
            return View();
        }
        
        public async Task<ViewResult> ShowAll()
        {
            var users = await _userRepository.GetAllIUsersAsync();
            return View("AllUsers", users);
        }

        public async Task<ViewResult> Add(User user)
        {
            await _userRepository.AddUserAsync(user);
            return View("Registered", user);
        }
        
        public async Task<ViewResult> Update(int id)
        {
            var user = await _userRepository.GetUserAsync(id);
            return View("Update", user);
        }
        
        public async Task<ViewResult> Edit(User user)
        {
            await _userRepository.EditUserAsync(user);
            return View("Registered", user);
        }
        
        public async Task<ViewResult> Delete(int id)
        {
            await _userRepository.DeleteUserAsync(id);
            return View("Index");
        }
    }
}