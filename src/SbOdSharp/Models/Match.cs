using System.Text.Json.Serialization;

namespace SbOdSharp
{
    public static class MatchPeriod
    {
        public const int FirstHalf = 1;
        public const int SecondHalf = 2;
        public const int FirstHalfOvertime = 3;
        public const int SecondHalfOvertime = 4;
        public const int PenaltyShootout = 5;
    }

    public record Match(
        [property: JsonPropertyName("match_id")] int MatchId,
        [property: JsonPropertyName("country_name")] string CountryName,
        [property: JsonPropertyName("match_date")] DateOnly MatchDate,
        [property: JsonPropertyName("kick_off")] TimeOnly? KickOff,
        [property: JsonPropertyName("competition")] Competition Competition,
        [property: JsonPropertyName("season")] Season Season,
        [property: JsonPropertyName("home_team")] HomeTeam HomeTeam,
        [property: JsonPropertyName("away_team")] AwayTeam AwayTeam,
        [property: JsonPropertyName("home_score")] int HomeScore,
        [property: JsonPropertyName("away_score")] int AwayScore,
        [property: JsonPropertyName("match_status")] string MatchStatus,
        [property: JsonPropertyName("match_status_360")] string MatchStatus360,
        [property: JsonPropertyName("last_updated")] DateTime LastUpdated,
        [property: JsonPropertyName("last_updated_360")] DateTime? LastUpdated360,
        [property: JsonPropertyName("metadata")] Metadata Metadata,
        [property: JsonPropertyName("match_week")] int MatchWeek,
        [property: JsonPropertyName("competition_stage")] CompetitionStage CompetitionStage,
        [property: JsonPropertyName("stadium")] Stadium? Stadium,
        [property: JsonPropertyName("referee")] Referee? Referee
    );
}
