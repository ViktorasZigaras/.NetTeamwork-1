using Homework.Domain.Interfaces;
using Homework.Domain.Services;
using Homework.WebApp.Data;
using Homework.WebApp.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Homework.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection ConfigureServices()
        {
            IServiceCollection services = new ServiceCollection();

            const string connectionString = "Server=localhost;Database=TeamWorkDB;Trusted_Connection=true;";

            services.AddDbContext<DataContext>(optionsAction => optionsAction.UseSqlServer(connectionString));
            services.AddTransient<DbContext, DataContext>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IAccountRepository, AccountRepository>();
            services.AddScoped<IAccountService, AccountService>();

            return services;
        }
    }
}