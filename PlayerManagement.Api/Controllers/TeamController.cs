using Microsoft.AspNetCore.Mvc;
using PlayerManagement.Core.Services;

namespace PlayerManagement.Api.Controllers
{
    [Route("api/teams")]
    [ApiController]
    public class TeamController : ControllerBase
    {
        private readonly ITeamService _teamService;

        public TeamController(ITeamService teamService)
        {
            _teamService = teamService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllTeams()
        {
            return Ok(await _teamService.GetAllTeamsAsync());
        }

        [HttpGet("{teamId}/players")]
        public async Task<IActionResult> GetAllTeamPlayers(int teamId)
        {
            return Ok(await _teamService.GetAllTeamPlayersAsync(teamId));
        }
    }
}
