using AutoMapper;
using PlayerManagement.Data.Repositories;
using PlayerManagement.Model.Responses;

namespace PlayerManagement.Core.Services
{
    public class TeamService : ITeamService
    {
        private readonly ITeamRepository _teamRepository;
        private readonly IMapper _mapper;

        public TeamService(ITeamRepository teamRepository, IMapper mapper)
        {
            _teamRepository = teamRepository;
            _mapper = mapper;
        }

        public async Task<List<GetAllTeamsResponse>> GetAllTeamsAsync()
        {
            var teams = await _teamRepository.GetAllTeamsAsync();

            var result = _mapper.Map<List<GetAllTeamsResponse>>(teams);

            return result;
        }

        public async Task<GetAllTeamPlayersResponse> GetAllTeamPlayersAsync(int teamId)
        {
            var teamPlayers = await _teamRepository.GetAllTeamPlayersAsync(teamId);

            var result = _mapper.Map<GetAllTeamPlayersResponse>(teamPlayers);

            return result;
        }
    }
}
