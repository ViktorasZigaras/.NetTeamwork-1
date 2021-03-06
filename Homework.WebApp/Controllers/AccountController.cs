﻿using Homework.Domain.Interfaces;
using Homework.Domain.Models;
using Homework.Domain.Services;
using Microsoft.AspNetCore.Mvc;

namespace Homework.WebApp.Controllers
{
    public class AccountController : Controller
    {
        private readonly IAccountRepository _accountRepository;
        private readonly IAccountService _accountService;

        public AccountController(IAccountRepository accountRepository, IAccountService accountService)
        {
            _accountRepository = accountRepository;
            _accountService = accountService;
        }
        public ViewResult Index()
        {
            var accounts = _accountRepository.GetAll();
            return View("Index", accounts);
        }
        [HttpPost]
        public ViewResult Topup(int id)
        {
            var model = new Topup();
            model.Id = id;
            return View("TopupForm", model);
        }
        public ActionResult TopupForm(Topup model)
        {
            if (ModelState.IsValid)
            {
                _accountRepository.Topup(model);
                TempData["MsgChangeStatus"] = "You are successfully topup account";
                return RedirectToAction("Index", "Account");
            }
            else
            {
                return View("TopupForm", model);
            }
        }
        public ViewResult Create()
        {
            var users = _accountRepository.GetAllUsers();
            return View("Create", users);
        }
        [HttpPost]
        public ActionResult CreateAccount(int id)
        {
            if(id != 0)
            {
                var newAccount = _accountService.GenerateNewAccount();
                newAccount.UserId = id;
                _accountRepository.AddAccount(newAccount);
                TempData["MsgChangeStatus"] = "You are successfully created new account!";
                return RedirectToAction("Index", "Account");
            } else
            {
                TempData["MsgChangeStatus"] = "You have to choose user!";
                var users = _accountRepository.GetAllUsers();
                return View("Create", users);
            }
            
        }
        [HttpPost]
        public ViewResult Delete(int id)
        {
            _accountRepository.Delete(id);
            TempData["MsgChangeStatus"] = "You are successfully deleted account";
            return Index();
        }
    }
}
