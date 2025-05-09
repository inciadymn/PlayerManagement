using Microsoft.Extensions.DependencyInjection;
using PlayerManagement.Data.Context;
using PlayerManagement.Data.Repositories;

namespace PlayerManagement.Data.Extensions
{
    public static class RegisterRepository
    {
        public static void AddScopeData(this IServiceCollection services)
        {
            services.AddDbContext<PlayerManagementDbContext>();
            services.AddScoped<IPlayerRepository, PlayerRepository>();
            services.AddScoped<ITeamRepository, TeamRepository>();
        }
    }
}
