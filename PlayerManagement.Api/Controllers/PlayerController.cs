using Microsoft.AspNetCore.Mvc;
using PlayerManagement.Core.Services;
using PlayerManagement.Model.Requests;

namespace PlayerManagement.Api.Controllers
{
    [Route("api/players")]
    [ApiController]
    public class PlayerController : ControllerBase
    {
        private readonly IPlayerService _playerService;

        public PlayerController(IPlayerService playerService)
        {
            _playerService = playerService;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetPlayerById([FromRoute]int id)
        {
            return Ok(await _playerService.GetPlayerByIdAsync(id));
        }

        [HttpPost()]
        public async Task<IActionResult> CreatePlayer([FromBody]CreatePlayerRequest player)
        {
            return Ok(await _playerService.CreatePlayerAsync(player));
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdatePlayer([FromRoute]int id, [FromBody]UpdatePlayerRequest player)
        {
            await _playerService.UpdatePlayerAsync(player, id);

            return Ok();
        }

        [HttpDelete("{id}/remove-team")]
        public async Task<IActionResult> RemovePlayerFromTeam([FromRoute]int id)
        {
            await _playerService.RemovePlayerFromTeamAsync(id);

            return Ok();
        }
    }
}
