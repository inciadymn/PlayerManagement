using Microsoft.AspNetCore.Mvc;
using PlayerManagement.Core.Services;

namespace PlayerManagement.Api.Controllers
{
    [Route("api/player")]
    [ApiController]
    public class PlayerController : ControllerBase
    {
        IPlayerService playerService;

        public PlayerController()
        {

        }
    }
}
