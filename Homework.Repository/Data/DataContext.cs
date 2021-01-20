using Microsoft.EntityFrameworkCore;
using Homework.Domain.Models;

namespace Homework.WebApp.Data
{
    public class DataContext : DbContext
    {
        public DbSet<Account> Accounts { get; set; }
        public DbSet<User> Users { get; set; }

        public DataContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                new User() {Id = 1, Name = "Dominick", LastName = "Crouch", PersonalId = 10512158741},
                new User() {Id = 2, Name = "Maegan", LastName = "Griffith", PersonalId = 2022081770},
                new User() {Id = 3, Name = "Ryan", LastName = "Smith", PersonalId = 10710237512}
            );
            modelBuilder.Entity<Account>().HasData(
                new Account {Id = 1, AccountNumber = "LT981088349522671550", Balance = 100, UserId = 1},
                new Account {Id = 2, AccountNumber = "LT981088349522671551", Balance = 80, UserId = 1},
                new Account {Id = 3, AccountNumber = "LT981088349522671552", Balance = 110, UserId = 2},
                new Account {Id = 4, AccountNumber = "LT981088349522671553", Balance = 10, UserId = 3},
                new Account {Id = 5, AccountNumber = "LT981088349522671554", Balance = 200, UserId = 3}
            );
        }
    }
}