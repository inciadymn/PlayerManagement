using PlayerManagement.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerManagement.Data.Repositories
{
    public interface ITeamRepository 
    {
        Task<List<Team>> GetAllTeamsAsync();

        Task<Team> GetAllTeamPlayersAsync(int teamId);
    }
}
