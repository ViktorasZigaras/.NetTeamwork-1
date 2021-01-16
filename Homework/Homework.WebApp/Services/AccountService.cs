using Homework.WebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework.WebApp.Services
{
    public class AccountService
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
        public Account GenerateNewAccount(User user)
        {
            var newAccount = new Account();
            newAccount.UserName = user.Name;
            //Tomai atkomentuok sias eilutes kai savo User modeli turesi prop LastName ir PersonalId
            //newAccount.UserLastName = user.LastName;
            //newAccount.PersonalId = user.PersonalId;
            newAccount.AccountNumber = GenerateAccountNumber();
            newAccount.Balance = 0;
            newAccount.User_id = user.Id;
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
