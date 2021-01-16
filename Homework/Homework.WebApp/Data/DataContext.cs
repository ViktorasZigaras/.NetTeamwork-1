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
        }
        
        // Seeding the initial data.
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(new User[]
            {
                new User()
                {
                    Id = 1,
                    Name = "Jonas",
                    LastName = "Jonaitis",
                    PersonalId = 39112220001
                },
                new User()
                {
                    Id = 2,
                    Name = "Petras",
                    LastName = "Petraitis",
                    PersonalId = 39112220002
                },
                new User()
                {
                    Id = 3,
                    Name = "Antanas",
                    LastName = "Antanaitis",
                    PersonalId = 39112220003
                }
                
            });
            
            modelBuilder.Entity<Account>().HasData(new Account[]
            {
                new Account
                {
                    Id = 1,
                    AccountNumber = "LT012345678901234567",
                    Balance = 0
                },
                new Account
                {
                    Id = 2,
                    AccountNumber = "LT012345678901234568",
                    Balance = 0
                },
                new Account
                {
                    Id = 3,
                    AccountNumber = "LT012345678901234569",
                    Balance = 0
                }
            });
        
            base.OnModelCreating(modelBuilder);
        }
    }
}