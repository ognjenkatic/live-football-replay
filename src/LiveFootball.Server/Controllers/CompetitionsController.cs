using LiveFootball.Application.Competitions;
using LiveFootball.Application.Matches.Models;
using LiveFootball.Application.Matches;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SbOdSharp;

namespace LiveFootball.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompetitionsController(CompetitionService competitionService, MatchService matchService) : ControllerBase
    {
        [HttpGet]
        public ICollection<Competition> GetCompetitions() => competitionService.GetCompetitions();

        [HttpGet("{competition:int}/{season:int}/matches")]
        public ICollection<MatchSummary> GetMatches(int competition, int season) => matchService.GetMatchesForCompetitionSeason(competition, season);
    }
}
