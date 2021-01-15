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
    }
}
