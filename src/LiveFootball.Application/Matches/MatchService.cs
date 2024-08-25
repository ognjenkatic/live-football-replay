using LiveFootball.Application.Matches.Models;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using SbOdSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace LiveFootball.Application.Matches
{
    public class MatchService(IOptions<OpenDataConfig> openDataConfig, IndexerService indexerService, ILogger<MatchService> logger)
    {
        const string matchesDirectoryPath = "matches";
        const string lineupsDirectoryPath = "lineups";
        const string eventsDirectoryPath = "events";

        private readonly OpenDataConfig _openDataConfig = openDataConfig.Value;
        private readonly IndexerService indexerService = indexerService;
        private readonly ILogger<MatchService> logger = logger;

        public ICollection<PlayEvent> GetMatchEvents(int matchId)
        {
            var eventsPath = Path.Join(_openDataConfig.RootDirectory, eventsDirectoryPath);

            if (!Directory.Exists(eventsPath))
            {
                throw new InvalidCastException(
                    "Events directory could not be found on specified path"
                );
            }

            var matchEventsPath = Directory.GetFiles(eventsPath).FirstOrDefault(f => f.EndsWith($"{matchId}.json"));

            if (matchEventsPath is null)
            {
                throw new InvalidCastException(
                    "Match events file could not be found"
                );
            }

            var matchEvents = JsonSerializer.Deserialize<PlayEvent[]>(
                File.ReadAllText(matchEventsPath)
            );

            if (matchEvents is null)
            {
                throw new InvalidCastException("Match lineup file found but could be be deserialized");
            }

            return matchEvents;
        }
        public ICollection<TeamLineup> GetMatchLineups(int matchId)
        {
            var lineupsPath = Path.Join(_openDataConfig.RootDirectory, lineupsDirectoryPath);

            if (!Directory.Exists(lineupsPath))
            {
                throw new InvalidCastException(
                    "Lineups directory could not be found on specified path"
                );
            }

            var matchLineupPath = Directory.GetFiles(lineupsPath).FirstOrDefault(f => f.EndsWith($"{matchId}.json"));

            if (matchLineupPath is null)
            {
                throw new InvalidCastException(
                    "Match lineup file could not be found"
                );
            }

            var matchLineup = JsonSerializer.Deserialize<TeamLineup[]>(
                File.ReadAllText(matchLineupPath)
            );

            if (matchLineup is null)
            {
                throw new InvalidCastException("Match lineup file found but could be be deserialized");
            }

            return matchLineup;
        }

        public Match GetMatch(int matchId)
        {
            
            if (!indexerService.TryGetMatchFile(matchId, out var matchPath) || matchPath is null)
            {
                throw new InvalidCastException(
                    "Match file could not be found"
                );
            }

            var matches = JsonSerializer.Deserialize<Match[]>(
                File.ReadAllText(matchPath)
            );

            if (matches is null)
            {
                throw new InvalidCastException("Match file found but could be be deserialized");
            }

            return matches.First(m => m.MatchId == matchId);
        }

        public ICollection<MatchSummary> GetMatchesForCompetitionSeason(int competitionId, int seasonId)
        {
            var matchesPath = Path.Join(_openDataConfig.RootDirectory, matchesDirectoryPath, $"{competitionId}");

            if (!Directory.Exists(matchesPath))
            {
                throw new InvalidCastException(
                    "Competition matches directory could not be found on specified path"
                );
            }

            var files = Directory.GetFiles(matchesPath);
            var matchespath = Directory.GetFiles(matchesPath).FirstOrDefault(f =>  new FileInfo(f).Name ==  $"{seasonId}.json");

            if (!File.Exists(matchespath))
            {
                throw new InvalidCastException("Competition season matches file not found at expected path");
            }

            var matches = JsonSerializer.Deserialize<Match[]>(File.ReadAllText(matchespath));

            if (matches is null)
            {
                throw new InvalidCastException("Could not deserialize matches");
            }
            return matches.Select(match => new MatchSummary { AwayGoals = match.AwayScore, AwayTeam = match.AwayTeam.AwayTeamName, HomeGoals = match.HomeScore, HomeTeam = match.HomeTeam.HomeTeamName , MatchId = match.MatchId}).ToList();
        }
    }
}
