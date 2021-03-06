using System.Threading.Tasks;
using Homework.Domain.Interfaces;
using Homework.Domain.Models;
using Homework.Domain.Services;
using Microsoft.AspNetCore.Mvc;

namespace Homework.WebApp.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserRepository _userRepository;
        private readonly IAccountService _accountService;

        public UserController(IUserRepository userRepository, IAccountService accountService)
        {
            _userRepository = userRepository;
            _accountService = accountService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<ViewResult> ShowAll()
        {
            var users = await _userRepository.GetAllUsersAsync();
            return View("AllUsers", users);
        }

        public async Task<ViewResult> TransferPayment(int senderId, string senderAccount, string recipientAccount,
            decimal amount)
        {
            var users = await _userRepository.TransferPaymentAsync(senderId, senderAccount, recipientAccount, amount);
            return View("AllUsers", users);
        }

        public async Task<ViewResult> Add(User user)
        {
            user.Accounts.Add(_accountService.GenerateNewAccount());
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