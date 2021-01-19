using System;
using Homework.Domain.Interfaces;
using Homework.Domain.Models;

namespace Homework.Domain.Services
{
    public class AccountService : IAccountService
    {
        public bool TryParseTopupInputValue(string input)
        {
            if (decimal.TryParse(input, out _))
            {
                return true;
            }
            return false;
        }
        public string ReplaceDot(string input)
        {
            if (input.Contains("."))
            {
                input = input.Replace(".", ",");
                return input;
            }
            return input;
        }
        public decimal ParseTopupInputValue(string input)
        {
            var topup = decimal.Parse(input);
            return topup;
        }
        public bool IsValueNegative(decimal input)
        {
            if (input < 0)
            {
                return true;
            }
            return false;
        }
        public Account GenerateNewAccount()
        {
            var newAccount = new Account();
            newAccount.AccountNumber = GenerateAccountNumber();
            newAccount.Balance = 0;
            return newAccount;
        }
        public string GenerateAccountNumber()
        {
            var rnd = new Random();
            string countryCode = "LT";
            string numberPart1 = rnd.Next(100000, 999999).ToString();
            string numberPart2 = rnd.Next(100000, 999999).ToString();
            string numberPart3 = rnd.Next(100000, 999999).ToString();
            string accountNumber = countryCode + numberPart1 + numberPart2 + numberPart3;
            return accountNumber;
        }
    }
}
