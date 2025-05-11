using AutoMapper;
using Moq;
using PlayerManagement.Core.Services;
using PlayerManagement.Data.Repositories;
using PlayerManagement.Model.Entities;
using PlayerManagement.Model.Enums;
using PlayerManagement.Model.Requests;
using PlayerManagement.Model.Responses;

namespace PlayerManagement.Test
{
    public class PlayerServiceTests
    {
        private readonly Mock<IPlayerRepository> _mockPlayerRepository;
        private readonly Mock<IMapper> _mockMapper;
        private readonly PlayerService _playerService;

        public PlayerServiceTests()
        {
            _mockPlayerRepository = new Mock<IPlayerRepository>();
            _mockMapper = new Mock<IMapper>();
            _playerService = new PlayerService(_mockPlayerRepository.Object, _mockMapper.Object);
        }

        [Fact]
        public async Task GetPlayerByIdAsync_WithValidId_ReturnPlayer()
        {
            //Arrange
            var player = new Player()
            {
                Id = 1,
                FullName = "test",
                Height = 180,
                DateOfBirth = DateTime.Parse("05.05.1990"),
                Position = "RightBack",
                Team = new Team
                {
                    Country = "Spain",
                    Name = "Real Madrid",
                    Id = 1
                }
            };

            _mockPlayerRepository.Setup(a => a.GetPlayerByIdAsync(1)).ReturnsAsync(player);

            _mockMapper.Setup(a => a.Map<GetPlayerByIdResponse>(player))
                .Returns(new GetPlayerByIdResponse
                {
                    Id = player.Id,
                    FullName = player.FullName,
                    Position = player.Position,
                    DateOfBirth = player.DateOfBirth,
                    Height = player.Height,
                    TeamName = player.Team.Name,
                    TeamId = player.Team.Id,
                    Age = (DateTime.Now.Year - player.DateOfBirth.Year)
                });

            //Act
            var result = await _playerService.GetPlayerByIdAsync(1);

            //Assert
            Assert.NotNull(result);
            Assert.IsType<GetPlayerByIdResponse>(result);
            Assert.True(result.Id == player.Id);
            Assert.True(result.FullName == player.FullName);
            Assert.True(result.Height == player.Height);
            Assert.True(result.TeamName == player.Team.Name);
        }

        [Fact]
        public async Task CreatePlayerAsync_WithCreatePlayerRequest_ReturnPlayer()
        {
            //Arrange
            var playerRequest = new CreatePlayerRequest()
            {
                FullName = "test",
                Height = 180,
                DateOfBirth = DateTime.Parse("05.05.1990"),
                Position = Position.Defender,
                TeamId = 1
            };

            var player = new Player()
            {
                FullName = playerRequest.FullName,
                Height = playerRequest.Height,
                DateOfBirth = playerRequest.DateOfBirth,
                Position = playerRequest.Position.ToString(),
                TeamId = playerRequest.TeamId
            };

            _mockMapper.Setup(a => a.Map<Player>(playerRequest))
                .Returns(player);

            _mockPlayerRepository.Setup(a => a.CreatePlayerAsync(player)).ReturnsAsync(player);

            _mockMapper.Setup(a => a.Map<CreatePlayerResponse>(player))
                .Returns(new CreatePlayerResponse
                {
                    Id = player.Id,
                    FullName = player.FullName,
                    Position = player.Position.ToString(),
                    DateOfBirth = player.DateOfBirth,
                    Height = player.Height,
                    TeamId = player.TeamId
                });

            //Act
            var result = await _playerService.CreatePlayerAsync(playerRequest);

            //Assert
            Assert.NotNull(result);
            Assert.IsType<CreatePlayerResponse>(result);
            Assert.True(result.FullName == playerRequest.FullName);
            Assert.True(result.Height == playerRequest.Height);
            Assert.True(result.DateOfBirth == playerRequest.DateOfBirth);
            Assert.True(result.Position == playerRequest.Position.ToString());
        }
    }
}
