using Homework.WebApp.Models;
using Microsoft.EntityFrameworkCore;

namespace Homework.WebApp.Data
{
    public class DataContext : DbContext
    {
        public DbSet<Bank> Banks { get; set; }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<User> Users { get; set; }
        
        public DataContext(DbContextOptions options) : base(options)
        {
        }
    }
}