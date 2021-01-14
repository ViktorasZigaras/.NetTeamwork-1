using System.Collections.Generic;

namespace Homework.WebApp.Models
{
    public class Bank
    {
        public string Name { get; set; }
        public List<Account> Accounts { get; set; }
        public List<User> Users { get; set; }
    }
}