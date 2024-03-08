using Microsoft.Extensions.Options;
using SbOdSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace LiveFootball.Application.Competitions
{
    public class CompetitionService(IOptions<OpenDataConfig> openDataConfig)
    {
        const string competitionFilePath = "competitions.json";
     
        private readonly OpenDataConfig _openDataConfig = openDataConfig.Value;

        public ICollection<Competition> GetCompetitions()
        {
            var competitionsPath = Path.Join(_openDataConfig.RootDirectory, competitionFilePath);
            if (!File.Exists(competitionsPath))
            {
                throw new InvalidCastException(
                    "Competitions file could not be found on specified path"
                );
            }

            var competitions = JsonSerializer.Deserialize<Competition[]>(
                File.ReadAllText(competitionsPath)
            );

            if (competitions is null)
            {
                throw new InvalidCastException(
                    "Competitions file found but could not deserialize contents"
                );
            }

            return competitions;
        }
    }
}
