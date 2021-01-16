﻿using Homework.WebApp.Repositories;
using Homework.WebApp.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public IActionResult Index()
        {
            var accounts = _accountRepository.GetAll();
            return View(accounts);
        }
        [HttpPost]
        public IActionResult Topup(int id, string topup)
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
            return RedirectToAction("Index");
        }
        [HttpPost]
        public IActionResult Delete(int id)
        {
            _accountRepository.Delete(id);
            return RedirectToAction("Index");
        }
    }
}