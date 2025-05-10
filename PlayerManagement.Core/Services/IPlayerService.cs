using PlayerManagement.Model.Requests;
using PlayerManagement.Model.Responses;

namespace PlayerManagement.Core.Services
{
    public interface IPlayerService
    {
        Task<GetPlayerByIdResponse> GetPlayerByIdAsync(int id);
        Task<CreatePlayerResponse> CreatePlayerAsync(CreatePlayerRequest playerRequest);
        Task UpdatePlayerAsync(UpdatePlayerRequest playerRequest, int id);
        Task RemovePlayerFromTeamAsync(int id);
    }
}
