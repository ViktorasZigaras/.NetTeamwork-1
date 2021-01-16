using System.Threading.Tasks;
using Homework.WebApp.Interfaces;
using Homework.WebApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace Homework.WebApp.Controllers
{
    public class LoginController : Controller
    {
        private readonly ILoginRepository _userRepository;

        public LoginController(ILoginRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<ViewResult> Login(User user)
        {
            // await _userRepository.AddUserAsync(user);
            return View("LogedIn", user);
        }

        /*public async Task<ViewResult> Add(User user)
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
        }*/
    }
}