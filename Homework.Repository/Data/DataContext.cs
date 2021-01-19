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
    }
}