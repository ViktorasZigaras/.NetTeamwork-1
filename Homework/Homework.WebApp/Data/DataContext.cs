using Homework.WebApp.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Homework.WebApp.Data
{
    public class DataContext : DbContext
    {
        public DbSet<Account> Accounts { get; set; }
        public DbSet<User> Users { get; set; }
        
        public DataContext(DbContextOptions options) : base(options)
        {
            if (!Accounts.Any())
            {
                Accounts.Add(new Account()
                {
                    UserName = "Jonas",
                    UserLastName = "Jonaitis",
                    PersonalId = 39112220001,
                    AccountNumber = "LT012345678901234567",
                    Balance = 0,
                    User_id = 1
                }); ;
                Accounts.Add(new Account()
                {
                    UserName = "Petras",
                    UserLastName = "Petraitis",
                    PersonalId = 39112220002,
                    AccountNumber = "LT012345678901234568",
                    Balance = 0,
                    User_id = 2
                });
                Accounts.Add(new Account()
                {
                    UserName = "Antanas",
                    UserLastName = "Antanaitis",
                    PersonalId = 39112220003,
                    AccountNumber = "LT012345678901234569",
                    Balance = 0,
                    User_id = 3
                });
                SaveChanges();
            }
        }
    }
}