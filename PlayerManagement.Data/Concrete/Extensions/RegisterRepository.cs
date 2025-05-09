using Microsoft.Extensions.DependencyInjection;
using PlayerManagement.Data.Concrete.Context;
using PlayerManagement.Data.Concrete.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerManagement.Data.Concrete.Extensions
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
