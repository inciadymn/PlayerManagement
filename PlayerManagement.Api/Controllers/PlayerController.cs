using Microsoft.AspNetCore.Mvc;
using PlayerManagement.Core.Services;

namespace PlayerManagement.Api.Controllers
{
    [Route("api/players")]
    [ApiController]
    public class PlayerController : ControllerBase
    {
        IPlayerService playerService;

        public PlayerController()
        {

        }
    }
}
