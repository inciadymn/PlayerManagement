using Microsoft.EntityFrameworkCore;
using PlayerManagement.Data.Context;
using PlayerManagement.Model.Entities;
using PlayerManagement.Model.Exceptions;

namespace PlayerManagement.Data.Repositories
{
    public class TeamRepository : ITeamRepository
    {
        private readonly PlayerManagementDbContext _context;

        public TeamRepository(PlayerManagementDbContext context)
        {
            _context = context;
        }

        public async Task<List<Team>> GetAllTeamsAsync()
        {
            return await _context.Teams.ToListAsync();
        }

        public async Task<Team> GetAllTeamPlayersAsync(int teamId)
        {
            var isTeamExist = await _context.Teams.AnyAsync(a => a.Id == teamId);

            if (!isTeamExist)
            {
                throw new CustomException($"Team cannot found");
            }

            var teamPlayers = await _context.Teams.Where(a=>a.Id == teamId).Include(a=>a.Players).FirstOrDefaultAsync(); 

            if (teamPlayers == null)
            {
                throw new CustomException($"Team players can not found by team id : {teamId}");
            }

            return teamPlayers;
        }
    }
}
