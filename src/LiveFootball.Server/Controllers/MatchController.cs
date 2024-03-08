using LiveFootball.Application.Matches;
using LiveFootball.Application.Matches.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SbOdSharp;

namespace LiveFootball.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MatchController(MatchService matchService) : ControllerBase
    {
        [HttpGet("{id}")]
        public Match GetMatch(int id) => matchService.GetMatch(id);
        
        [HttpGet("{id}/lineup")]
        public ICollection<TeamLineup> GetMatchLineups(int id) => matchService.GetMatchLineups(id);

    }
}
