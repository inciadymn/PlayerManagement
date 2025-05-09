using Microsoft.Extensions.DependencyInjection;
using PlayerManagement.Core.Services;
using PlayerManagement.Data.Concrete.Extensions;

namespace PlayerManagement.Core.Extensions
{
    public static class RegisterService
    {
        public static void AddScopeCore(this IServiceCollection services)
        {
            services.AddScopeData();
            services.AddScoped<IPlayerService, PlayerService>();
            services.AddScoped<ITeamService, TeamService>();
        }
    }
}
