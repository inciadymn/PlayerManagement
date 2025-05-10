using PlayerManagement.Model.Responses;

namespace PlayerManagement.Core.Services
{
    public interface ITeamService
    {
        Task<List<GetAllTeamsResponse>> GetAllTeamsAsync();

        Task<GetAllTeamPlayersResponse> GetAllTeamPlayersAsync(int teamId);
    }
}
