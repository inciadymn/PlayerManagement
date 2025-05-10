using PlayerManagement.Model.Entities;

namespace PlayerManagement.Data.Repositories
{
    public interface IPlayerRepository
    {
        Task<Player> GetPlayerByIdAsync(int id);
        Task<Player> CreatePlayerAsync(Player player);
        Task UpdatePlayerAsync(Player player);
        Task RemovePlayerFromTeamAsync(int id);
    }
}
