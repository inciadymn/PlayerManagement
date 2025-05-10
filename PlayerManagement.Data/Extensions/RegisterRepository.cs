using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using PlayerManagement.Data.Context;
using PlayerManagement.Data.Repositories;

namespace PlayerManagement.Data.Extensions
{
    public static class RegisterRepository
    {
        public static void AddScopeData(this IServiceCollection services, string connectionString)
        {
            services.AddDbContext<PlayerManagementDbContext>(options => options.UseSqlServer(connectionString));
            services.AddScoped(typeof(DbContext), typeof(PlayerManagementDbContext));

            services.AddScoped<IPlayerRepository, PlayerRepository>();
            services.AddScoped<ITeamRepository, TeamRepository>();
        }
    }
}
