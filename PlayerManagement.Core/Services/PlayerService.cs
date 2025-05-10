using AutoMapper;
using PlayerManagement.Data.Repositories;
using PlayerManagement.Model.Entities;
using PlayerManagement.Model.Exceptions;
using PlayerManagement.Model.Requests;
using PlayerManagement.Model.Responses;

namespace PlayerManagement.Core.Services
{
    public class PlayerService : IPlayerService
    {
        private readonly IPlayerRepository _playerRepository;
        private readonly IMapper _mapper;

        public PlayerService(IPlayerRepository playerRepository, IMapper mapper)
        {
            _playerRepository = playerRepository;
            _mapper = mapper;
        }

        public async Task<GetPlayerByIdResponse> GetPlayerByIdAsync(int id)
        {
            var player = await _playerRepository.GetPlayerByIdAsync(id);

            var result = _mapper.Map<GetPlayerByIdResponse>(player);

            return result;
        }

        public async Task<CreatePlayerResponse> CreatePlayerAsync(CreatePlayerRequest playerRequest)
        {
            var player = await _playerRepository.CreatePlayerAsync(_mapper.Map<Player>(playerRequest));

            var result = _mapper.Map<CreatePlayerResponse>(player);

            return result;
        }

        public async Task UpdatePlayerAsync(UpdatePlayerRequest playerRequest, int id)
        {
            var player = _mapper.Map<Player>(playerRequest);
            player.Id = id;

            await _playerRepository.UpdatePlayerAsync(player);
        }

        public async Task RemovePlayerFromTeamAsync(int id)
        {
            if (id <= 0)
            {
                throw new CustomException($"TeamId can not be empty");
            }

            await _playerRepository.RemovePlayerFromTeamAsync(id);
        }
    }
}
