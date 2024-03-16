using LiveFootball.Server.DTOs;
using LiveFootball.Server.Services;
using Microsoft.AspNetCore.Mvc;

namespace LiveFootball.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Teams(SportsDbClient client) : ControllerBase
    {
        private readonly SportsDbClient client = client;

        [HttpGet]
        public async Task<Team> FindTeam(string name)
        {
            var team = await client.FindTeam(name);

            return team ?? new Team
            {
                StrTeamBadge = "https://www.thesportsdb.com//images//media//team//badge//uyhbfe1612467038.png"
            };
        }
    }
}
