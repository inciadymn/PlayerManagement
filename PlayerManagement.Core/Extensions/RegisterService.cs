using Microsoft.Extensions.DependencyInjection;
using PlayerManagement.Core.Services;
using PlayerManagement.Data.Extensions;

namespace PlayerManagement.Core.Extensions
{
    public static class RegisterService
    {
        public static void AddScopeCore(this IServiceCollection services, string connectionString)
        {
            services.AddScopeData(connectionString);
            services.AddScoped<IPlayerService, PlayerService>();
            services.AddScoped<ITeamService, TeamService>();
        }
    }
}
