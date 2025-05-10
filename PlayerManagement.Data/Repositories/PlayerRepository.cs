using Microsoft.EntityFrameworkCore;
using PlayerManagement.Data.Context;
using PlayerManagement.Model.Entities;
using PlayerManagement.Model.Exceptions;
using System.Numerics;

namespace PlayerManagement.Data.Repositories
{
    public class PlayerRepository : IPlayerRepository
    {
        private readonly PlayerManagementDbContext _context;

        public PlayerRepository(PlayerManagementDbContext context)
        {
            _context = context;
        }

        public async Task<Player> GetPlayerByIdAsync(int id)
        {
            var player = await _context.Players.Where(a => a.Id == id).Include(a => a.Team).FirstOrDefaultAsync();

            if (player == null)
            {
                throw new CustomException($"Player can not found by id:{id}");
            }

            return player;
        }

        public async Task<Player> CreatePlayerAsync(Player player)
        {
            if (player == null)
            {
                throw new CustomException($"Player data can not be null or empty");
            }

            if (player.TeamId <= 0)
            {
                throw new CustomException($"TeamId can not be empty");
            }

            await IsTeamExist(player.TeamId);

            player.CreatedDate = DateTime.Now;

            await _context.Players.AddAsync(player);
            await _context.SaveChangesAsync();

            return player;
        }

        public async Task UpdatePlayerAsync(Player player)
        {
            if (player == null)
            {
                throw new CustomException($"Player data can not be null or empty");
            }

            var result = await _context.Players.Where(a => a.Id == player.Id).FirstOrDefaultAsync();

            if (result == null)
            {
                throw new CustomException($"Player can not found");
            }

            await IsTeamExist(player.TeamId);

            result.FullName = player.FullName;
            result.Height = player.Height;
            result.Position = player.Position;
            result.DateOfBirth = player.DateOfBirth;
            result.UpdatedDate = DateTime.Now;
            result.TeamId = player.TeamId;

            await _context.SaveChangesAsync();
        }

        public async Task RemovePlayerFromTeamAsync(int id)
        {
            var player = await _context.Players.Where(a => a.Id == id).FirstOrDefaultAsync();

            if (player == null)
            {
                throw new CustomException($"Player can not found by id:{id}");
            }

            player.TeamId = null;

            await _context.SaveChangesAsync();
        }

        private async Task IsTeamExist(int? teamId)
        {
            if (!teamId.HasValue)
            {
                return;
            }

            var isTeamExist = await _context.Teams.AnyAsync(a => a.Id == teamId);

            if (!isTeamExist)
            {
                throw new CustomException($"Team cannot found");
            }
        }
    }
}
