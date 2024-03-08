using System.Text.Json.Serialization;

namespace SbOdSharp
{
    public record AwayTeam(
        [property: JsonPropertyName("away_team_id")] int AwayTeamId,
        [property: JsonPropertyName("away_team_name")] string AwayTeamName,
        [property: JsonPropertyName("away_team_gender")] string AwayTeamGender,
        [property: JsonPropertyName("away_team_group")] string AwayTeamGroup,
        [property: JsonPropertyName("country")] Country Country
    )
    {
        [JsonPropertyName("managers")]
        public List<Manager> Managers { get; set; } = [];
    }
}
