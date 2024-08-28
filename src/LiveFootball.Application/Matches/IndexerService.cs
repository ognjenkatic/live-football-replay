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
    public class IndexerService(IOptions<OpenDataConfig> openDataConfig, ILogger<IndexerService> logger)
    {
        const string matchesDirectoryPath = "matches";
        private readonly Dictionary<int, string> _matchLocationDictionary = new();
        private readonly OpenDataConfig _openDataConfig = openDataConfig.Value;
        private readonly ILogger<IndexerService> logger = logger;

        public void IndexMatches()
        {
            var matchesPath = Path.Join(_openDataConfig.RootDirectory, matchesDirectoryPath);

            if (!Directory.Exists(matchesPath))
            {
                throw new InvalidCastException(
                    "Matches directory could not be found on specified path"
                );
            }

            var matchFilePaths = Directory.GetDirectories(matchesPath).SelectMany(f => Directory.GetFiles(f)).Where(f => f.EndsWith(".json"));

            if (!matchFilePaths.Any())
            {
                throw new InvalidCastException("Could not find any match json files");
            }

            foreach (var matchFile in matchFilePaths)
            {
                var matches = JsonSerializer.Deserialize<Match[]>(
                    File.ReadAllText(matchFile)
                );

                if (matches is null)
                {
                    logger.LogWarning("Could not deserialize matches from {Path}", matchFile);
                    continue;
                }

                foreach (var match in matches)
                {
                    _matchLocationDictionary.Add(match.MatchId, matchFile);
                }
            }

            logger.LogInformation("Indexing complete, indexed {NumberOfIndexedMatches}", _matchLocationDictionary.Count);
        }

        public bool TryGetMatchFile(int matchId, out string? path) => _matchLocationDictionary.TryGetValue(matchId, out path);
        
    }
}