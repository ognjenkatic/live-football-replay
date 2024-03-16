using LiveFootball.Server.DTOs;
using LiveFootball.Server.Services;
using Microsoft.AspNetCore.Mvc;

namespace LiveFootball.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlayersController(SportsDbClient sportsDbClient) : ControllerBase
    {
        private readonly SportsDbClient sportsDbClient = sportsDbClient;

        [HttpGet]
        public async Task<Player> GetPlayerInfoAsync(string name)
        {
            return await sportsDbClient.FindPlayer(name) ?? new Player
            {
                StrCutout = "https://www.thesportsdb.com//images//media//player//cutout//j1ua6n1638766587.png"
            };
        }
    }
}
