using Homework.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework.Domain.Interfaces
{
    public interface IAccountService
    {
        bool TryParseTopupInputValue(string input);
        string ReplaceDot(string input);
        decimal ParseTopupInputValue(string input);
        bool IsValueNegative(decimal input);
        Account GenerateNewAccount();
        string GenerateAccountNumber();
    }
}
