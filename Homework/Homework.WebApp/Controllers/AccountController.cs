using Homework.WebApp.Services;
using Microsoft.AspNetCore.Mvc;
using Homework.WebApp.Interfaces;

namespace Homework.WebApp.Controllers
{
    public class AccountController : Controller
    {
        private readonly IAccountRepository _accountRepository;
        private readonly AccountService _accountService;

        public AccountController(IAccountRepository accountRepository, AccountService accountService)
        {
            _accountRepository = accountRepository;
            _accountService = accountService;
        }
        public ViewResult Index()
        {
            var accounts = _accountRepository.GetAll();
            // return View(accounts);
            return View("Index", accounts);
        }
        [HttpPost]
        public ViewResult Topup(int id, string topup)
        {
            var input = _accountService.ReplaceDot(topup);
            bool parse = _accountService.TryParseTopupInputValue(input);
            if (parse)
            {
                var top = _accountService.ParseTopupInputValue(input);
                bool isNegative = _accountService.IsValueNegative(top);
                if (isNegative)
                {
                    TempData["MsgChangeStatus"] = "Data type can't be negative";
                } else
                {
                    _accountRepository.Topup(id, top);
                }
            } else
            {
                TempData["MsgChangeStatus"] = "Data type is invalid";
            }

            return Index();
        }
        [HttpPost]
        public ViewResult Delete(int id)
        {
            _accountRepository.Delete(id);
            return Index();
        }
    }
}
